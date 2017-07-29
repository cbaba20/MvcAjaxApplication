using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAjaxApplication.Controllers
{
    public class HomeController : Controller
    {
        DemoApplicationDBEntities db = new DemoApplicationDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            //Product[] _product = db.Products.ToArray();

            return View(); //_product
        }

        public PartialViewResult GetProductDescription()
        {
            var productList = db.Products.ToList();

            return PartialView(productList);
        }

        [HttpGet]
        public PartialViewResult ChangeProductPrice(int productId,decimal newPrice)
        {
            var _productList = db.Products.Where(p => p.ProductId == productId).ToList();
            Product product = _productList.FirstOrDefault();
            product.Price = newPrice;
            db.SaveChanges();
            return PartialView("GetProductDescription", _productList);
        }
    }
}