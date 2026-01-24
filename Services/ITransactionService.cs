using System.Collections.Generic;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Services
{
    public interface ITransactionService
    {
        // ----------------------------------------------------
        // C - Create (New Transaction + Linked Procedures)
        // ----------------------------------------------------
        /// <summary>
        /// Creates a new Transaction record and links it to the specified list of Procedure IDs
        /// via the TransactedProcedures junction table.
        /// </summary>
        /// <param name="newTransaction">The Transaction object to be saved.</param>
        /// <param name="procedureIds">A collection of IDs for procedures included in this transaction.</param>
        /// <returns>The newly created Transaction entity.</returns>
        Task<Transaction> AddTransaction(Transaction transaction, IEnumerable<int> procedureIds);

        // ----------------------------------------------------
        // R - Read (Query Operations)
        // ----------------------------------------------------

        /// <summary>
        /// Retrieves a single Transaction entity by its primary key.
        /// </summary>
        /// <param name="id">The ID of the transaction.</param>
        /// <returns>The Transaction entity, or null if not found.</returns>
        Task<Transaction?> GetTransactionById(int id);

        /// <summary>
        /// Retrieves all Transaction entities, typically including related procedure data.
        /// </summary>
        Task<List<Transaction>> GetAllTransactions();

        // ----------------------------------------------------
        // U - Update (Modify an existing Transaction)
        // ----------------------------------------------------

        /// <summary>
        /// Updates an existing Transaction entity. This method handles changes to the main
        /// transaction details and updates the associated procedures.
        /// </summary>
        /// <param name="updatedTransaction">The Transaction entity with updated details.</param>
        /// <param name="newProcedureIds">The complete, new list of Procedure IDs that should be linked.</param>
        Task UpdateTransaction(Transaction updatedTransaction, IEnumerable<int> newProcedureIds);

        // ----------------------------------------------------
        // D - Delete
        // ----------------------------------------------------

        /// <summary>
        /// Deletes a Transaction and cascades the deletion to the TransactedProcedures records.
        /// </summary>
        /// <param name="id">The ID of the transaction to delete.</param>

        Task DeleteTransaction(int id);

        // ----------------------------------------------------
        // D - Delete
        // ----------------------------------------------------

        /// <summary>
        /// Deletes all Transactions and cascades the deletion to the TransactedProcedures records.
        /// </summary>
        /// <param none>No param as it deletes all entreis in the mentioned tables</param>
        Task ClearAllDataAsync();

        // ----------------------------------------------------
        // Business Logic (Example)
        // ----------------------------------------------------

        /// <summary>
        /// Calculates the total cost for a specific transaction by summing the costs of all linked procedures.
        /// </summary>
        /// 

        Task<decimal> CalculateTotalCostAsync(int transactionId);
        // Returns a Tuple: (List of items, Total count of items)
        Task<List<Transaction>> SearchTransactionsAsync(string? searchTerm);
    }
}