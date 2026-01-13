using System;
using System.Collections.Generic;
using CARED.Models;

namespace CARED.Data
{
    public static class TransactionSeedData
    {
        // --- 1. DEFINE TRANSACTIONS ---
        public static List<Transaction> GetTransactions()
        {
            var list = new List<Transaction>();

            // All test cases set to December 2025 for easy reporting
            DateTime baseDate = new DateTime(2025, 12, 01);

            // CASE A: Standard Data (IDs 1-10)
            // Just normal transactions to fill the background
            for (int i = 1; i <= 10; i++)
            {
                list.Add(CreateTransaction(i, baseDate.AddDays(1), "Standard Patient"));
            }

            // CASE B: The "Monster" Slip (ID 11)
            // This will have 60 procedures. It should start on a new page and span 2 pages.
            list.Add(CreateTransaction(11, baseDate.AddDays(5), "THE MONSTER (60 ITEMS)"));

            // CASE C: The "Tiny" Neighbor (ID 12)
            // This is paired with ID 11. It should start at the top, but its "Total"
            // must be pushed ALL the way down to match ID 11.
            list.Add(CreateTransaction(12, baseDate.AddDays(5), "TINY NEIGHBOR (1 ITEM)"));

            // CASE D: The "Page Edge" Pair (IDs 13 & 14)
            // These have ~35 items. They fit on one page individually, 
            // but might trigger a page break if the header takes up too much space.
            list.Add(CreateTransaction(13, baseDate.AddDays(10), "EDGE CASE LEFT (35 ITEMS)"));
            list.Add(CreateTransaction(14, baseDate.AddDays(10), "EDGE CASE RIGHT (35 ITEMS)"));

            return list;
        }

        // --- 2. LINK PROCEDURES TO TRANSACTIONS ---
        public static List<TransactedProcedure> GetTransactedProcedures()
        {
            var links = new List<TransactedProcedure>();

            // A. Link Standard Data (IDs 1-10 get 3 items each)
            for (int t = 1; t <= 10; t++)
            {
                links.Add(new TransactedProcedure { TransactionID = t, ProcedureID = 1 });
                links.Add(new TransactedProcedure { TransactionID = t, ProcedureID = 2 });
                links.Add(new TransactedProcedure { TransactionID = t, ProcedureID = 3 });
            }

            // B. Link "The Monster" (ID 11 gets 60 items: Proc IDs 1 to 60)
            for (int p = 1; p <= 60; p++)
            {
                links.Add(new TransactedProcedure { TransactionID = 11, ProcedureID = p });
            }

            // C. Link "Tiny Neighbor" (ID 12 gets 1 item)
            links.Add(new TransactedProcedure { TransactionID = 12, ProcedureID = 5 });

            // D. Link "Edge Cases" (IDs 13 & 14 get 35 items each: Proc IDs 10 to 44)
            for (int p = 10; p < 45; p++)
            {
                links.Add(new TransactedProcedure { TransactionID = 13, ProcedureID = p });
                links.Add(new TransactedProcedure { TransactionID = 14, ProcedureID = p });
            }

            return links;
        }

        // Helper to keep code clean
        private static Transaction CreateTransaction(int id, DateTime date, string name)
        {
            return new Transaction
            {
                TransactionID = id,
                CsNo = $"CS-{id}",
                Date = date,
                Name = name,
                Personnel = "Dr. Test",
                Company = "Test Corp",
                Insurer = "Test Insurer"
            };
        }
    }
}