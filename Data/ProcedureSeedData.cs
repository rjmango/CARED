using System.Collections.Generic;
using CARED.Models;

namespace CARED.Data
{
    public static class ProcedureSeedData
    {
        public static List<Procedure> GetInitialProcedures()
        {
            var procedures = new List<Procedure>();

            // 1. REAL PROCEDURES (IDs 1-5)
            procedures.Add(new Procedure { ProcedureID = 1, ProcedureName = "URINALYSIS", Amount = 182.00M, Group = "LABORATORY", SubGroup = "CLINICAL MICROSCOPY" });
            procedures.Add(new Procedure { ProcedureID = 2, ProcedureName = "CBC", Amount = 300.00M, Group = "LABORATORY", SubGroup = "HEMATOLOGY" });
            procedures.Add(new Procedure { ProcedureID = 3, ProcedureName = "CHEST PA", Amount = 340.00M, Group = "IMAGING", SubGroup = "THORACIC" });
            procedures.Add(new Procedure { ProcedureID = 4, ProcedureName = "UPPER ABDOMEN", Amount = 1100.00M, Group = "ULTRASOUND", SubGroup = "GENERAL" });
            procedures.Add(new Procedure { ProcedureID = 5, ProcedureName = "ECG 12L WITH RS", Amount = 506.00M, Group = "IMAGING", SubGroup = "OTHERS" });

            // 2. DUMMY PROCEDURES (IDs 6-100)
            // We need these to test "Huge Slips" because a Transaction cannot 
            // have duplicate ProcedureIDs.
            for (int i = 6; i <= 100; i++)
            {
                procedures.Add(new Procedure
                {
                    ProcedureID = i,
                    ProcedureName = $"TEST PROCEDURE {i}", // e.g. "TEST PROCEDURE 55"
                    Amount = 100.00M + i, // Varied amounts
                    Group = "STRESS TEST",
                    SubGroup = "GENERATED"
                });
            }

            return procedures;
        }
    }
}