using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer

        ControlBlog controlblog = new ControlBlog();
        ControlWriter controlwriter = new ControlWriter();
        public PartialViewResult AboutWriter(int id)
        {
            var writerDetail = controlblog.GetBlogById(id);
            return PartialView(writerDetail);
        }

        public PartialViewResult WritersPopular(int id)
        {
            var blogWriterid = controlblog.ListAll().Where(x => x.BlogID == id).Select(y => y.WriterID).FirstOrDefault();
            var writerblogs = controlblog.GetBlogByWriter(blogWriterid);
            return PartialView(writerblogs);
        }

        public ActionResult ListWriter()
        {
            var writerlists = controlwriter.ListAll();
            return View(writerlists);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            controlwriter.AddWriterBLayer(p);
            return RedirectToAction("ListWriter");
        }

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            Writer writer = controlwriter.FindWriter(id);
            return View(writer);
        }

        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            controlwriter.EditWriter(p);
            return RedirectToAction("ListWriter");
        }
    }
}