using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
    }
}
