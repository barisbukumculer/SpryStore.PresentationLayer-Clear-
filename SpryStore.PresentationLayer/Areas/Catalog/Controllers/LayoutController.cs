using Microsoft.AspNetCore.Mvc;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    public class LayoutController : Controller
    {
        [Area("Catalog")]
        public IActionResult _CatalogLayout()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult Navbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
