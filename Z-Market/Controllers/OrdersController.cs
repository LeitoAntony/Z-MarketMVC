using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Z_Market.Models;
using Z_Market.ViewModels;

namespace Z_Market.Controllers
{
    public class OrdersController : Controller
    {
        Z_MarketContext db = new Z_MarketContext();
        public ActionResult NewOrder()
        {
            var orderView = new OrderView();
            orderView.Customer = new Customer();
            orderView.ProductOrders = new List<ProductOrder>();

            var list = db.Customers.ToList();
            list.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un cliente]" });
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");

            return View(orderView);
        }
        [HttpPost]
        public ActionResult NewOrder(OrderView orderView)
        {
            var list = db.Customers.ToList();
            list.Add(new Customer { CustomerId = 0, FirstName = "[Seleccione un cliente]" });
            list = list.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(list, "CustomerId", "FullName");
            return View(orderView);
        }

        public ActionResult AddProduct(ProductOrder productOrder)
        {
            var list = db.Products.ToList();
            list.Add(new Product { ProductId = 0, Description = "[Seleccione un producto]" });
            list = list.OrderBy(c => c.Description).ToList();
            ViewBag.ProductId = new SelectList(list, "ProductId", "Description");
            return View(productOrder);
        }

        [HttpPost]
        public ActionResult AddProduct(FormCollection form)
        {
            var list = db.Products.ToList();
            list.Add(new Product { ProductId = 0, Description = "[Seleccione un producto]" });
            list = list.OrderBy(c => c.Description).ToList();
            ViewBag.ProductId = new SelectList(list, "ProductId", "Description");
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}