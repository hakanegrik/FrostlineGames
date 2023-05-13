using System;
using System.Collections.Generic;
using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;

namespace ECommerce.Services.Impls
{
    public class DiscountService : IDiscountService
    {
        IDiscountRepository _discountRepository;
        private ICategoryService _categoryService;



        public DiscountService(IDiscountRepository discountRepository,ICategoryService categoryService)
        {
            _discountRepository = discountRepository;
            _categoryService = categoryService;

        }
        public void Create(DiscountViewModel model)
        {
            var categoryData = _categoryService.GetById(model.CategoryId);

            var requestModel = new Discount();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.CategoryName = categoryData.Name;
            requestModel.CategoryId = model.CategoryId;
            requestModel.DiscountRate = model.DiscountRate;
            requestModel.StartDate = model.StartDate;
            requestModel.EndDate = model.EndDate;
            requestModel.IsActive = model.IsActive;

            _discountRepository.Add(requestModel);

        }

        public void Delete(Discount discount)
        {
            _discountRepository.Delete(discount);
        }

        public List<Discount> GetAll()
        {
            return _discountRepository.GetAll();
        }

        public Discount GetById(int id)
        {
            return _discountRepository.GetById(id);
        }

        public void Update(DiscountViewModel model)
        {
            var discounData = _discountRepository.GetById(model.Id);
            var categoryData = _categoryService.GetById(model.CategoryId);

            _discountRepository.Delete(discounData);

            var requestModel = new Discount();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.CategoryName = categoryData.Name;
            requestModel.CategoryId = model.CategoryId;
            requestModel.DiscountRate = model.DiscountRate;
            requestModel.StartDate = model.StartDate;
            requestModel.EndDate = model.EndDate;
            requestModel.IsActive = model.IsActive;

            _discountRepository.Update(requestModel);
        }
    }
}
