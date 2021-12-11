using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class EmailSubscribeController : Controller
    {
        [HttpGet]
        public PartialViewResult AddEmail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddEmail(EmailSubscribe prm)
        {
            ControlEmailSubscribe emailS = new ControlEmailSubscribe();
            emailS.AddBusinessL(prm);
            return PartialView(prm);
        }
    }
}