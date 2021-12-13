using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment

        ControlComment ccm = new ControlComment();

        public PartialViewResult GetComment(int id)
        {
            var commentList = ccm.CommentByBlog(id);
            return PartialView(commentList);
        }

        [HttpGet]
        public PartialViewResult LeaveAComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult LeaveAComment(Comments com)
        {
            ccm.CommentAdd(com);
            return PartialView();
        }

        public ActionResult AdminCommentListTrue()
        {
            var commentlist = ccm.CommentByStatusTrue();
            return View(commentlist);
        }

        public ActionResult AdminCommentListFalse()
        {
            var commentlist = ccm.CommentByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangedToFalse(int id)
        {
            ccm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }

        public ActionResult StatusChangedToTrue(int id)
        {
            ccm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }


    }
}