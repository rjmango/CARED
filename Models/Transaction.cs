using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CARED.Models
{
    // Represents the 'Transaction' entity
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }

        [Required]
        [StringLength(100)]
        public string Insurer { get; set; }
        [Required]
        [StringLength(50)]
        public string CsNo { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Personnel { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        // Navigation property for the many-to-many junction table
        public ICollection<TransactedProcedure> TransactedProcedures { get; set; } = new List<TransactedProcedure>();
    }
}