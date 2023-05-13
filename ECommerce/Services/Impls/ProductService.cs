using System;
using System.Collections.Generic;
using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;

namespace ECommerce.Services.Impls
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(ProductViewModel model)
        {

            var requestModel = new Product();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.CategoryId = model.CategoryId;
            requestModel.Price = model.OldPrice;
            requestModel.IsActive = model.IsActive;

            _productRepository.Add(requestModel);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(ProductViewModel model)
        {
            var productData = _productRepository.GetById(model.Id);

            _productRepository.Delete(productData);

            var requestModel = new Product();

            requestModel.Name = model.Name;
            requestModel.Id = model.Id;
            requestModel.CategoryId = model.CategoryId;
            requestModel.Price = model.OldPrice;
            requestModel.IsActive = model.IsActive;

            _productRepository.Update(requestModel);
        }
    }
}
