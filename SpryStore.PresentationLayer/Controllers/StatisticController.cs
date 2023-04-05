using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;

namespace SpryStore.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context context= new Context(); 
            ViewBag.categoryCount=context.Categories.Count();
            ViewBag.productCount=context.Products.Count();
            ViewBag.electricProductCount=context.Products.Where(x=>x.ProductID==1).Count();
            ViewBag.priceUnder5000 = context.Products.Where(x => x.Price <= 5000).Count();
            ViewBag.avgprice=context.Products.Average(x=>x.Price);  
            return View();
        }
    }
}
