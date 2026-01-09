using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using CARED.Models;
using CARED.Data;

namespace CARED.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly AppDatabaseContext _dbContext;
        public TransactionService(AppDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Transaction>> SearchTransactionsAsync(string? searchTerm)
        {
            // 1. Start query and Include relationships
            var query = _dbContext.Transactions
                .Include(t => t.TransactedProcedures)
                .ThenInclude(tp => tp.Procedure)
                .AsNoTracking();

            // 2. Apply Filter (if search term is provided)
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string term = searchTerm.ToLower().Trim();
                query = query.Where(t =>
                    t.Name.ToLower().Contains(term) ||
                    t.CsNo.ToLower().Contains(term) ||
                    t.Personnel.ToLower().Contains(term) ||
                    t.Company.ToLower().Contains(term) ||
                    t.Insurer.ToLower().Contains(term));
            }

            // 3. Always Sort by Date (Most Recent First) and execute
            return await query
                .OrderByDescending(t => t.Date)
                .ToListAsync();
        }
        public async Task<Transaction> AddTransaction(Transaction transaction, IEnumerable<int> procedureIds)
        {
            // 1. Add the main transaction entity
            _dbContext.Transactions.Add(transaction);

            foreach(var procedureId in procedureIds)
            {
                // 2. Create the junction records to link procedures
                var transactedProcedure = new TransactedProcedure
                {
                    TransactionID = transaction.TransactionID,
                    ProcedureID = procedureId
                };

                _dbContext.TransactedProcedures.Add(transactedProcedure);
            }

            // 3. Save all changes (inserts the Transaction and all TransactedProcedure links)
            await _dbContext.SaveChangesAsync();
            return transaction;
        }
        public Task<Transaction?> GetTransactionById(int id)
        {
            return _dbContext.Transactions
                .Include(t => t.TransactedProcedures)
                .ThenInclude(tp => tp.Procedure)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.TransactionID == id);
        }
        public Task<List<Transaction>> GetAllTransactions()
        {
            // Eager load related data to avoid N+1 query issues in the UI layer
            return _dbContext.Transactions
                .Include(t => t.TransactedProcedures)
                .ThenInclude(tp => tp.Procedure)
                .AsNoTracking()
                .OrderByDescending(t => t.Date)
                .ToListAsync();
        }
        public async Task UpdateTransaction(Transaction updatedTransaction, IEnumerable<int> newProcedureIds)
        {
            // 1. Update the main Transaction entity details
            _dbContext.Transactions.Update(updatedTransaction);

            // 2. Handle Junction Table updates (the linked procedures)
            // Fetch the existing transaction with its current procedures
            var existingTransaction = await _dbContext.Transactions
                .Include(t => t.TransactedProcedures)
                .FirstOrDefaultAsync(t => t.TransactionID == updatedTransaction.TransactionID);

            if(existingTransaction == null)
            {
                throw new KeyNotFoundException($"Transaction with ID {updatedTransaction.TransactionID} not found.");
            }

            // Remove old links that are not in the newProcedureIds list
            var linksToRemove = existingTransaction.TransactedProcedures
                .Where(tp => !newProcedureIds.Contains(tp.ProcedureID))
                .ToList();

            foreach(var link in linksToRemove)
            {
                existingTransaction.TransactedProcedures.Remove(link);
            }
            // Identify and add new links
            var existingProceureIds = existingTransaction.TransactedProcedures.Select(tp => tp.ProcedureID).ToList();
            var procedureIdsToAdd = newProcedureIds.Except(existingProceureIds).ToList();

            if (procedureIdsToAdd.Any())
            {
                // NOTE: We still need to create new junction entities for added procedures, 
                // but we only use the IDs, avoiding a database SELECT query here too.
                foreach (var procedureId in procedureIdsToAdd)
                {
                    existingTransaction.TransactedProcedures.Add(new TransactedProcedure
                    {
                        TransactionID = existingTransaction.TransactionID,
                        ProcedureID = procedureId
                    });
                }
            }

            // Save all changes (updates to Transaction and changes to TransactedProcedures)
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteTransaction(int id)
        {
            // Use stub entity for deletion if you only have the ID (avoids fetching the entire entity)
            var transactionToDelete = new Transaction { TransactionID = id };
            _dbContext.Transactions.Remove(transactionToDelete);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // This handles the case where the entity was already deleted or never existed.
                // Depending on requirements, you might ignore this or log it.
            }
        }
        public async Task<decimal> CalculateTotalCostAsync(int transactionId)
        {
            // We join the three tables (Transaction, TransactedProcedures, Procedures)
            // and use SUM to calculate the total amount for the specified transaction.

            var totalCost = await _dbContext.TransactedProcedures
                .Where(tp => tp.TransactionID == transactionId)
                .Select(tp => tp.Procedure.Amount) // Select the Amount from the joined Procedure table
                .SumAsync();

            return totalCost;
        }

    }
}