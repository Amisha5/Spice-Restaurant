using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
    public class ShoppingCart
    {
        [Key]
        [Display(Name = "CartId")]
        public int CartId { get; set; }

        [Required]
        [Display(Name = "UserId")]
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "count")]
        public int count { get; set; }

        [Required]
        [Display(Name = "MenuId")]
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public virtual MenuItem MenuItem { get; set; }

    }
}
