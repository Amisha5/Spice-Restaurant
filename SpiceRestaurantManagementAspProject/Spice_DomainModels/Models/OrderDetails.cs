using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }

        [Required]
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public virtual MenuItem MenuItem { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual OrderSummary OrderSummary { get; set; }
    }
}
