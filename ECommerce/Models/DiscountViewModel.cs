using System;
using System.Collections.Generic;
using ECommerce.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Models
{
    public class DiscountViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int DiscountRate { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public int SelectedCategory { get; set; }

    }
}
