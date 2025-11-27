using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CARED.Models 
{
    // Represents the 'Procedures' entity
    public class Procedure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProcedureID { get; set; }

        [Required]
        [StringLength(255)]
        public string ProcedureName { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // Use decimal for currency
        public decimal Amount { get; set; }

        // Navigation property for the many-to-many junction table
        public ICollection<TransactedProcedure> TransactedProcedures { get; set; } = new List<TransactedProcedure>();
    }
}