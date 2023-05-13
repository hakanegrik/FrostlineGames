using System;
using System.Collections.Generic;
using ECommerce.Entities;
using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IDiscountService
    {
        void Create(DiscountViewModel entity);
        void Delete(Discount entity);
        void Update(DiscountViewModel entity);
        List<Discount> GetAll();
        Discount GetById(int id);
    }
}
