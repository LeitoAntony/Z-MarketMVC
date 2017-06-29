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

            var list = db.DocumentTypes.OrderBy(c => c.Description).ToList();
            list.Add(new DocumentType { DocumentId = 0, Description = "[Seleccione un tipo de documento]" });
            list = list.OrderBy(c => c.Description).ToList();
            ViewBag.DocumentId = new SelectList(list, "DocumentId", "Description");

            return View(orderView);
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