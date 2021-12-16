using Microsoft.AspNetCore.Mvc;
using MVCWEB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWEB.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesRepository obj = new CategoriesRepository();
        public IActionResult Index()
        {
            //CategoriesRepository obj = new CategoriesRepository();
            return View(obj.List());
        }



    }
}
