using BusinessLayer.Concrete;
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

        ControlBlog bm = new ControlBlog();
        public PartialViewResult AboutWriter(int id)
        {
            var writerDetail = bm.GetBlogById(id);
            return PartialView(writerDetail);
        }

        public PartialViewResult WritersPopular(int id)
        {
            var blogWriterid = bm.ListAll().Where(x => x.BlogID == id).Select(y => y.WriterID).FirstOrDefault();
            var writerblogs = bm.GetBlogByWriter(blogWriterid);
            return PartialView(writerblogs);
        }
    }
}