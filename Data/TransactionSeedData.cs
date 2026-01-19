using System;
using System.Collections.Generic;
using CARED.Models;

namespace CARED.Data
{
    public static class TransactionSeedData
    {
        // Generate 30 dummy transactions
        public static List<Transaction> GetTransactions()
        {
            var transactions = new List<Transaction>();
            var companies = new[] { "Acme Corp", "Globex", "Soylent Corp", "Initech", "Umbrella Corp", "Stark Ind" };
            var personnel = new[] { "Dr. Smith", "Nurse Joy", "Dr. House", "Dr. Strange", "Nurse Jackie" };
            var insurers = new[] { "Maxicare", "PhilHealth", "Intellicare", "Medicard", "Etiqa" };
            var names = new[] { "John Doe", "Jane Smith", "Alice Jones", "Bob Brown", "Charlie Day", "Diana Prince", "Evan Wright", "Fiona Gallagher" };

            // We use a fixed date for consistency, or DateTime.Now.
            // For seeding migrations, it's safer to use a fixed anchor if you want deterministic data, 
            // but for test data, varying dates is fine.
            DateTime baseDate = new DateTime(2025, 12, 01);

            for (int i = 1; i <= 30; i++)
            {
                transactions.Add(new Transaction
                {
                    TransactionID = i, // Must specify ID for seeding
                    CsNo = $"CS No. {1000 + i}",
                    // Create dates that are spread out over the last 30 days to test sorting later
                    Date = baseDate.AddDays(i % 30),
                    Name = names[i % names.Length], // Append number to make names unique-ish
                    Personnel = personnel[i % personnel.Length],
                    Company = companies[i % companies.Length],
                    Insurer = insurers[i % insurers.Length]
                });
            }

            return transactions;
        }

        // Generate the links between Transactions and Procedures
        public static List<TransactedProcedure> GetTransactedProcedures()
        {
            var links = new List<TransactedProcedure>();

            // For each of the 30 transactions, assign 1 to 3 random procedures
            // Note: ProcedureIDs in your ProcedureSeedData.cs range from 1 to 75.
            for (int transId = 1; transId <= 30; transId++)
            {
                // Deterministic "randomness" based on ID to avoid duplicate keys during migration
                // Transaction 1 gets Procedure 1 and 10
                // Transaction 2 gets Procedure 2 and 11, etc.

                // Add first procedure
                int proc1 = (transId % 75) + 1;
                links.Add(new TransactedProcedure { TransactionID = transId, ProcedureID = proc1 });

                // Add a second procedure to every even transaction
                if (transId % 2 == 0)
                {
                    int proc2 = ((transId + 5) % 75) + 1;
                    if (proc2 != proc1) // Prevent duplicates
                    {
                        links.Add(new TransactedProcedure { TransactionID = transId, ProcedureID = proc2 });
                    }
                }
            }

            return links;
        }
    }
}