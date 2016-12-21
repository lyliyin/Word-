using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CastleDemo.Domain;
using CastleDemo.Domain.Models;
using CastleDemo.Domain.IRepository;
using System.Linq.Expressions;

namespace CastleDemo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Expression<Func<Product, bool>> condition = m => m.productName.Contains("产品");
            Expression<Func<Product, object>> order = m => m.productId;

            var products = Factories.Repository<IRepository<Product>>().Find( order: order,condition: condition);

            return View(products);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
