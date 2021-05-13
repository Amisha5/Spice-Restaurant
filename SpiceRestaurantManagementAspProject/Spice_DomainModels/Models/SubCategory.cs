using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
   public  class SubCategory
    {
        [Key]
        public int SId { get; set; }



        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required(ErrorMessage = "Sub Category Name is required")]
        [Display(Name = "Sub Category")]
        public string SubCategoryName { get; set; }
    }
}
