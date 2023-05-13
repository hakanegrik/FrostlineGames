using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ECommerce.Models;
using ECommerce.Services;
using ECommerce.Entities;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {

        private IProductService _productService;
        private IDiscountService _discountService;
        private ICategoryService _categoryService;



        public HomeController(IProductService productService, IDiscountService discountService, ICategoryService categoryService)
        {
            _productService = productService;
            _discountService = discountService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewModel model = new ViewModel();

            model.Product = _productService.GetAll();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DiscountProducts()
        {
            var model = new List<ProductViewModel>();


            var producData = _productService.GetAll();

            DateTime today = DateTime.Today;

            var discounData = _discountService.GetAll().Where(x => x.StartDate <= today && x.EndDate >= today).ToList();


            foreach (var p in producData)
            {
                foreach (var d in discounData)
                {
                    if (d.CategoryId == p.CategoryId)
                    {

                        var product = new ProductViewModel();

                        product.Id = p.Id;
                        product.Name = p.Name;
                        product.CategoryName = _categoryService.GetById(p.CategoryId).Name;
                        product.OldPrice = p.Price;
                        product.DiscountPrice = (p.Price * d.DiscountRate) / 100;
                  
                        model.Add(product);
                    }
                }
            }

            return View(model);
        }

    }
}
