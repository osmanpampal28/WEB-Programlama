using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        ControlAbout abm = new ControlAbout();
        public ActionResult Index()
        {
            var aboutcontent = abm.ListAll();
            return View(aboutcontent);
        }

        public PartialViewResult Footer()
        {
            var aboutContentList = abm.ListAll();
            return PartialView(aboutContentList);
            //return PartialView();
        }

        public PartialViewResult WritersTeam()
        {
            ControlWriter writ = new ControlWriter();
            var writerList = writ.ListAll();
            return PartialView(writerList);
        }

        public PartialViewResult LearnFromUs()
        {
            
            return PartialView();
        }
    }
}