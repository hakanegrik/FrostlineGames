using System;
namespace ECommerce.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
    }
}
