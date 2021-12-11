using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje.Controllers
{
  
    public class BlogController : Controller
    {
        // GET: Blog

        

        ControlBlog obj = new ControlBlog(); // controlBlog Business Layerdan bir nesne olusturmak

        public ActionResult Index()
        {
            return View();
        }


        
        //___________________________________PartialView lerin Olusturulmasi_________________________________________________________
        public PartialViewResult GetBlog(int page =1)
        {
            var listblog = obj.ListAll().ToPagedList(page,3);
            return PartialView(listblog);
        }

        public PartialViewResult GeneralPosts()
        {
         
            var blogTitle1="";  var blogTitle2 = ""; var blogTitle3 = ""; var blogTitle4 = ""; var blogTitle5 = "";
            var blogImage1=""; var blogImage2 = ""; var blogImage3 = ""; var blogImage4 = ""; var blogImage5 = "";

            DateTime blogDate1 = new DateTime(); DateTime blogDate2 = new DateTime(); DateTime blogDate3 = new DateTime();
            DateTime blogDate4 = new DateTime(); DateTime blogDate5 = new DateTime();

            ViewBag.blogTitle1 = SeeTitle(1, blogTitle1); ViewBag.blogTitle2 = SeeTitle(2, blogTitle2); ViewBag.blogTitle3 = SeeTitle(1002, blogTitle3); ViewBag.blogTitle4 = SeeTitle(1003, blogTitle4); ViewBag.blogTitle5 = SeeTitle(1004, blogTitle5);
            ViewBag.blogImage1 = SeeImage(1, blogImage1); ViewBag.blogImage2 = SeeImage(2, blogImage2); ViewBag.blogImage3 = SeeImage(1002, blogImage3); ViewBag.blogImage4 = SeeImage(1003, blogImage4); ViewBag.blogImage5 = SeeImage(1004, blogImage5);
            ViewBag.blogDate1 = SeeDate(1, blogDate1); ViewBag.blogDate2 = SeeDate(2, blogDate2); ViewBag.blogDate3 = SeeDate(1002, blogDate3); ViewBag.blogDate4 = SeeDate(1003, blogDate4); ViewBag.blogDate5 = SeeDate(1004, blogDate5);

            return PartialView();
        }

       
        public PartialViewResult OtherPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetail()
        {
            return View();
        }

        public PartialViewResult Cover_Blog(int id)
        {
            var blogDetailList = obj.GetBlogById(id);
            return PartialView(blogDetailList);
        }

        public PartialViewResult BlogLongText(int id)  // Bütün Metin
        {
            var blogDetailList = obj.GetBlogById(id);
            return PartialView(blogDetailList);
        }

        public ActionResult BlogCategories(int id)
        {
            var blogListByCategory = obj.GetBlogByCategory(id);
            var categoryName = obj.GetBlogByCategory(id).Select(y => y.Categories.CategoriesName).FirstOrDefault();
            ViewBag.categoryname = categoryName;
            var categoryDescription = obj.GetBlogByCategory(id).Select(y => y.Categories.CategoryDescription).FirstOrDefault();
            ViewBag.categorydescription = categoryDescription;
            return View(blogListByCategory);
        }

     
        public string SeeTitle(int id, string head)
        {
           head = obj.ListAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
           Select(y => y.BlogHeader).FirstOrDefault();

           return head;
        }

        public string SeeImage(int id, string img)
        {
            img = obj.ListAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
                Select(y => y.BlogImage).FirstOrDefault();
            return img;
        }

        public DateTime SeeDate(int id, DateTime dt)
        {

            dt = obj.ListAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoriesID == id).
                Select(y => y.BlogDate).FirstOrDefault();

            return dt;

        }
    }
}