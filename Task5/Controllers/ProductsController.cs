using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task5.Data;
using Task5.Models;

namespace Task5.Controllers
{
    public class ProductsController : Controller
    {
        private List<Product> products;

        public ProductsController()
        {
            products = Task5.Data.Products.ProductList;
        }

        public ActionResult List()
        {            
            return View(products);
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Product Details";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = products.Where(x => x.Id == id).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                int index = products.FindIndex(x => x.Id == product.Id);
                products[index] = product;

                return RedirectToAction("List");
            }               
                            
            return View(product);
        }
    }
}