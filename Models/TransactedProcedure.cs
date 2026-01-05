using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CARED.Models
{
    // Represents the junction table 'TransactedProcedures'
    public class TransactedProcedure
    {
        // Foreign Key 1 (will be part of the composite key)
        public int TransactionID { get; set; }

        // Foreign Key 2 (will be part of the composite key)
        public int ProcedureID { get; set; }

        // Navigation properties to the parent entities
        public Transaction Transaction { get; set; }
        public Procedure Procedure { get; set; }
    }
}