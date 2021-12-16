using Microsoft.AspNetCore.Mvc;
using MVCWEB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWEB.Controllers
{
    public class ContactController : Controller
    {
        ContactRepository obj = new ContactRepository();
        public IActionResult Index()
        {
            return View(obj.List());
        }
    }
}
