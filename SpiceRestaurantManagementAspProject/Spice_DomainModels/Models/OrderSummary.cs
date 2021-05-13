using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
    public class OrderSummary
    {
        [Key]
        public int OId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int TotalOrder { get; set; }
        [Required]
        public DateTime PickupDate { get; set; }
        [Required]
        public DateTime PickUpTime { get; set; }
        
        [Required]
        public string PaymentStatus { get; set; }

        public string Comments { get; set; }

        [Required]
        public string TransactionId { get; set; }

        [Required]
        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        public virtual MenuItem MenuItem { get; set; }
    }
}
