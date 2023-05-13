using System;
using System.Collections.Generic;
using ECommerce.Entities;

namespace ECommerce.Models
{
    public class ViewModel
    {
        public List<Product> Product { get; set; }
        public List<Category> Category { get; set; }
        public List<Discount> Discount { get; set; }
    }
}
