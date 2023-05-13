using System;
using System.Collections.Generic;
using ECommerce.Entities;
using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IProductService
    {
        void Create(ProductViewModel entity);
        void Delete(Product entity);
        void Update(ProductViewModel entity);
        List<Product> GetAll();
        Product GetById(int id);
    }
}
