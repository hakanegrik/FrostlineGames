using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public int SelectedCategory { get; set; }
    }
}
