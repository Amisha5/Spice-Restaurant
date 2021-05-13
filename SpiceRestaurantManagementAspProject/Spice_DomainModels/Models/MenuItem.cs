using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DomainModels.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Menu Name")]
        public string MenuName { get; set; }

        public string Descriptions { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater then Zero")]
        public int Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")] //string name contains name of foreign key property
        public virtual Category Category { get; set; }

        [Display(Name = "SubCategory")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")] //string name contains name of foreign key property
        public virtual SubCategory SubCategory { get; set; }

        public string Spicyness { get; set; }
        public enum Espicy { NA, Spicy, Not_Spicy, Very_Spicy }

        public string MenuImages { get; set; }

    }
}
