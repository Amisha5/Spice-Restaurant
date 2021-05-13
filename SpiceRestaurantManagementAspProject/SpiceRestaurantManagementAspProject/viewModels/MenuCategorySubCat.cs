using Spice_DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpiceRestaurantManagementAspProject.viewModels
{
    public class MenuCategorySubCat
    {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public MenuItem menuItemview { get; set; }

    }
}