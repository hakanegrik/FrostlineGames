using System;
namespace ECommerce.Entities
{
    public class Discount : BaseEntity
    {
        public int DiscountRate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
