using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories

        ControlCategories obj = new ControlCategories();
        public ActionResult Index()
        {
            var values_Categories = obj.List_All();
            return View(values_Categories);
        }

        public PartialViewResult CategoryBlogDet()
        {
            var values_Categories = obj.List_All();
            return PartialView(values_Categories);
        }
    }
}