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
        // Initialized to string.Empty to satisfy non-nullable reference type check in .NET 6+ projects
        public string ProcedureName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")] // Use decimal for currency
        public decimal Amount { get; set; }

        [Required]
        [StringLength(100)]
        // Initialized to string.Empty to satisfy non-nullable reference type check in .NET 6+ projects
        public string Group { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        // Initialized to string.Empty to satisfy non-nullable reference type check in .NET 6+ projects
        public string SubGroup { get; set; } = string.Empty;
    }
}