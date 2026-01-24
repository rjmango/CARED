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
                    t.Insurer.ToLower().Contains(term) ||
                    t.TransactedProcedures.Any(tp => tp.Procedure.ProcedureName.ToLower().Contains(term)));
            }

            // 3. Sort by CS Number
            return await query
                .OrderBy(t => t.CsNo)
                .ToListAsync();
        }
        public async Task<Transaction> AddTransaction(Transaction transaction, IEnumerable<int> procedureIds)
        {
            //// 1. Add the main transaction entity
            //_dbContext.Transactions.Add(transaction);

            //foreach(var procedureId in procedureIds)
            //{
            //    // 2. Create the junction records to link procedures
            //    var transactedProcedure = new TransactedProcedure
            //    {
            //        TransactionID = transaction.TransactionID,
            //        ProcedureID = procedureId
            //    };

            //    _dbContext.TransactedProcedures.Add(transactedProcedure);
            //}

            //// 3. Save all changes (inserts the Transaction and all TransactedProcedure links)
            //await _dbContext.SaveChangesAsync();
            //return transaction;

            // 1. Clear any existing links just in case
            transaction.TransactedProcedures = new List<TransactedProcedure>();

            // 2. Add the junction records to the Navigation Property
            foreach (var procedureId in procedureIds)
            {
                // Notice: We do NOT set TransactionID here!
                // We are adding this to the collection INSIDE the transaction object.
                transaction.TransactedProcedures.Add(new TransactedProcedure
                {
                    ProcedureID = procedureId
                    // EF will fill in the TransactionID automatically during SaveChanges
                });
            }

            // 3. Add the main transaction entity
            // EF will "see" the children inside the TransactedProcedures list
            _dbContext.Transactions.Add(transaction);

            // 4. Save all changes
            // EF inserts the Transaction, gets the new ID from the DB,
            // applies it to the children, and then inserts the junction records.
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
                .OrderBy(t => t.CsNo) 
                .ToListAsync();
        }
        public async Task UpdateTransaction(Transaction updatedTransaction, IEnumerable<int> newProcedureIds)
        {
            // 1. Update the main Transaction entity details
            _dbContext.Transactions.Update(updatedTransaction);

            // 2. Fetch the EXISTING record from the database (Tracked by EF)
            var existingTransaction = await _dbContext.Transactions
                .Include(t => t.TransactedProcedures)
                .FirstOrDefaultAsync(t => t.TransactionID == updatedTransaction.TransactionID);

            if (existingTransaction == null)
            {
                throw new KeyNotFoundException($"Transaction with ID {updatedTransaction.TransactionID} not found.");
            }

            // 3. Update Scalar Properties
            // Copy values from the form object (updatedTransaction) to the database object (existingTransaction)
            existingTransaction.CsNo = updatedTransaction.CsNo;
            existingTransaction.Name = updatedTransaction.Name;
            existingTransaction.Date = updatedTransaction.Date;
            existingTransaction.Personnel = updatedTransaction.Personnel;
            existingTransaction.Company = updatedTransaction.Company;
            existingTransaction.Insurer = updatedTransaction.Insurer;

            // 4. Handle Junction Table Updates (Add/Remove Procedures)

            // A. Identify links to REMOVE (Present in DB, but NOT in the new list)
            var linksToRemove = existingTransaction.TransactedProcedures
                .Where(tp => !newProcedureIds.Contains(tp.ProcedureID))
                .ToList();

            foreach (var link in linksToRemove)
            {
                existingTransaction.TransactedProcedures.Remove(link);
            }

            // B. Identify links to ADD (Present in new list, but NOT in DB)
            var existingProcedureIds = existingTransaction.TransactedProcedures
                .Select(tp => tp.ProcedureID)
                .ToList();

            var procedureIdsToAdd = newProcedureIds
                .Except(existingProcedureIds)
                .ToList();

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

            // 4. Save Changes
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

        public async Task ClearAllDataAsync()
        {
            // Start a transaction to ensure atomic deletion
            using (var dbTransaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    // 1. Remove all Junction entries first to satisfy foreign key constraints
                    _dbContext.TransactedProcedures.RemoveRange(_dbContext.TransactedProcedures);

                    // 2. Remove all Transactions
                    _dbContext.Transactions.RemoveRange(_dbContext.Transactions);

                    await _dbContext.SaveChangesAsync();
                    await dbTransaction.CommitAsync();
                }
                catch
                {
                    await dbTransaction.RollbackAsync();
                    throw;
                }
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