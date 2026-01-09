using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Data
{
    public static class ProcedureSeedData
    {
        public static List<Procedure> GetInitialProcedures()
        {
            return new List<Procedure>
            {
                // NOTE: The Primary Key (ProcedureID) must be explicitly provided for HasData
                new Procedure
                {
                    ProcedureID = 1,
                    ProcedureName = "URINALYSIS",
                    Amount = 182.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "I. CLINICAL MICROSCOPY"
                },
                new Procedure
                {
                    ProcedureID = 2,
                    ProcedureName = "CBC",
                    Amount = 300.00M,
                    Group = "LABORATORY TESTS",
                    SubGroup = "III. HEMATOLOGY"
                },
                new Procedure
                {
                    ProcedureID = 3,
                    ProcedureName = "CHEST PA",
                    Amount = 340.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "V. THORACIC"
                },
                new Procedure
                {
                    ProcedureID = 4,
                    ProcedureName = "UPPER ABDOMEN",
                    Amount = 1100.00M,
                    Group = "ULTRASOUND SERVICES",
                    SubGroup = "I. GENERAL"
                },
                new Procedure
                {
                    ProcedureID = 5,
                    ProcedureName = "ECG 12L WITH RS",
                    Amount = 506.00M,
                    Group = "IMAGING SERVICES",
                    SubGroup = "VI. OTHERS"
                }
            };
        }
    }
}
