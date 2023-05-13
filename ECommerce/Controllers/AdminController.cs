using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private IDiscountService _discountService;
        private ICategoryService _categoryService;



        public AdminController(IProductService productService, IDiscountService discountService, ICategoryService categoryService)
        {
            _productService = productService;
            _discountService = discountService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
         
            ViewModel model = new ViewModel();

            model.Product = _productService.GetAll();

            return View(model);
        }

        public IActionResult Discount()
        {
            ViewModel model = new ViewModel();

            model.Discount = _discountService.GetAll();

            return View(model);
        }

        public IActionResult CreateDiscount()
        {

            var model = new DiscountViewModel();


            model.Categories = new List<SelectListItem>();

            foreach (var item in _categoryService.GetAll())
            {
                model.Categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }



            return View(model);
        }

        [HttpPost]
        public ActionResult CreateDiscount(DiscountViewModel model) 
        {
            model.CategoryId = model.SelectedCategory;
            _discountService.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult EditDiscount(int id)
        {

            var discounData = _discountService.GetById(id);
            var model = new DiscountViewModel();

            model.Name = discounData.Name;
            model.Id = discounData.Id;
            model.CategoryName = discounData.CategoryName;
            model.CategoryId = discounData.CategoryId;
            model.DiscountRate = discounData.DiscountRate;
            model.StartDate = discounData.StartDate;
            model.EndDate = discounData.EndDate;
            model.IsActive = discounData.IsActive;

            model.Categories = new List<SelectListItem>();

            foreach (var item in _categoryService.GetAll())
            {
                model.Categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult EditDiscount(DiscountViewModel model)
        {
            model.CategoryId = model.SelectedCategory;

            _discountService.Update(model);

            return RedirectToAction("Index");
        }

        public IActionResult CreateProduct()
        {

            var model = new ProductViewModel();


            model.Categories = new List<SelectListItem>();

            foreach (var item in _categoryService.GetAll())
            {
                model.Categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateProduct(ProductViewModel model)  // bir kategoriye birden fazla discount uygulanamaz. 12 15 arası indirim var. 14-17 girerse kabul etme. 
        {
            model.CategoryId = model.SelectedCategory;

            _productService.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {

            var productData = _productService.GetById(id);
            var model = new ProductViewModel();

            model.Name = productData.Name;
            model.Id = productData.Id;
            model.CategoryId = productData.CategoryId;
            model.OldPrice = productData.Price;
            model.IsActive = productData.IsActive;


            model.Categories = new List<SelectListItem>();

            foreach (var item in _categoryService.GetAll())
            {
                model.Categories.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }


            return View(model);
        }

        [HttpPost]
        public ActionResult EditProduct(ProductViewModel model)
        {
            model.CategoryId = model.SelectedCategory;

            _productService.Update(model);

            return RedirectToAction("Index");
        }
        
    }
}
