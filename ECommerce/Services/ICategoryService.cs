using System;
using System.Collections.Generic;
using ECommerce.Entities;

namespace ECommerce.Services
{
    public interface ICategoryService 
    {
        void Create(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
        List<Category> GetAll();
        Category GetById(int id);
    }
}
