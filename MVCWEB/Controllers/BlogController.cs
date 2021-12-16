using Microsoft.AspNetCore.Mvc;
using MVCWEB.Models;
using MVCWEB.Repositories;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWEB.Controllers
{
    public class BlogController : Controller
    {
        BlogRepository obj = new BlogRepository();
        public IActionResult Index()
        {
           

            var blogTitle1 = ""; var blogTitle2 = ""; var blogTitle3 = ""; var blogTitle4 = ""; var blogTitle5 = "";
            var blogImage1 = ""; var blogImage2 = ""; var blogImage3 = ""; var blogImage4 = ""; var blogImage5 = "";

            DateTime blogDate1 = new DateTime(); DateTime blogDate2 = new DateTime(); DateTime blogDate3 = new DateTime();
            DateTime blogDate4 = new DateTime(); DateTime blogDate5 = new DateTime();

            ViewBag.blogTitle1 = SeeTitle(1, blogTitle1); ViewBag.blogTitle2 = SeeTitle(2, blogTitle2); ViewBag.blogTitle3 = SeeTitle(3, blogTitle3); ViewBag.blogTitle4 = SeeTitle(4, blogTitle4); ViewBag.blogTitle5 = SeeTitle(5, blogTitle5);
            ViewBag.blogImage1 = SeeImage(1, blogImage1); ViewBag.blogImage2 = SeeImage(2, blogImage2); ViewBag.blogImage3 = SeeImage(3, blogImage3); ViewBag.blogImage4 = SeeImage(4, blogImage4); ViewBag.blogImage5 = SeeImage(5, blogImage5);
            ViewBag.blogDate1 = SeeDate(1, blogDate1); ViewBag.blogDate2 = SeeDate(2, blogDate2); ViewBag.blogDate3 = SeeDate(3, blogDate3); ViewBag.blogDate4 = SeeDate(4, blogDate4); ViewBag.blogDate5 = SeeDate(5, blogDate5);
            return View(obj.List());
        }

        public IActionResult GetBlog()
        {
            return View(obj.List());

        }

        public string SeeTitle(int id, string head)
        {
            head = obj.List().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
            Select(y => y.BlogHeader).FirstOrDefault();

            return head;
        }

        public string SeeImage(int id, string img)
        {
            img = obj.List().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
                Select(y => y.BlogImage).FirstOrDefault();
            return img;
        }

        public DateTime SeeDate(int id, DateTime dt)
        {

            dt = obj.List().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
                Select(y => y.BlogDate).FirstOrDefault();

            return dt;

        }
    }
}
