﻿using System;
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

        public ActionResult List(List<Product> products)
        {
            if (products == null) products = Products.ProductList;
            return View(products);
        }

        public ActionResult ListFilter(Categories category, int priceFrom, int priceTo)
        {
            List<Product> productsFiltered = Products.ProductList.Where(x => x.Category == category && x.Price > priceFrom && x.Price < priceTo).ToList();
            return View("List", productsFiltered);
        }

        public ActionResult Details(Product product)
        {            
            return View(product);
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

                return RedirectToAction("Details", product);
            }               
                            
            return View(product);
        }
    }
}