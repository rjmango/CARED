using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Services
{
    public class TransactionCacheService
    {
        private readonly TransactionService _transactionService;
        private List<Transaction>? _cachedTransactions;

        public TransactionCacheService(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        // This method ensures the cache is ready
        private async Task EnsureCacheLoaded()
        {
            if (_cachedTransactions == null)
            {
                // Fetch everything once from the database
                _cachedTransactions = await _transactionService.GetAllTransactions();
            }
        }

        public void AddToCache(Transaction newTransaction)
        {
            // We only add to the list if the cache has already been loaded
            // If it's null, the Retrieve tab will fetch fresh data from the DB anyway
            if (_cachedTransactions != null)
            {
                _cachedTransactions.Add(newTransaction);
            }
        }

        public async Task<List<Transaction>> SearchCachedTransactionsAsync(string? searchTerm)
        {
            await EnsureCacheLoaded();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return _cachedTransactions.OrderBy(t => t.CsNo).ToList();
            }

            string term = searchTerm.ToLower().Trim();

            // Perform the search in-memory using LINQ to Objects
            return _cachedTransactions
                .Where(t =>
                    (t.Name?.ToLower().Contains(term) ?? false) ||
                    (t.CsNo?.ToLower().Contains(term) ?? false) ||
                    (t.Personnel?.ToLower().Contains(term) ?? false) ||
                    (t.Insurer?.ToLower().Contains(term) ?? false) ||
                    t.TransactedProcedures.Any(tp => tp.Procedure.ProcedureName.ToLower().Contains(term))
                )
                .OrderBy(t => t.CsNo)
                .ToList();
        }

        public void InvalidateCache() => _cachedTransactions = null;
    }
}
