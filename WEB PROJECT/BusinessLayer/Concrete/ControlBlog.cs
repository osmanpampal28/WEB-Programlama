using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlBlog
    {
        Repository<Blog> blogrp = new Repository<Blog>();

        // degerleri listeleme
        public List<Blog> ListAll()
        {
            return blogrp.List();
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogrp.List(x => x.BlogID == id);
        }
        
        public List<Blog> GetBlogByWriter(int id)
        {
            return blogrp.List(x => x.WriterID == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return blogrp.List(x => x.CategoriesID == id);
        }

        public int BlogAddBLayer(Blog b)
        {
            if(b.BlogHeader=="" || b.BlogImage=="" || b.BlogHeader.Length<=5
                || b.BlogDetail.Length <= 200)
            {
                return -1;
            }

            return blogrp.Insert(b);
        }

        public int BlogDeleteBLayer(int par)
        {
            Blog b = blogrp.Find(x => x.BlogID == par);
            return blogrp.Delete(b); 
        }

        public Blog FindBlog(int getid)
        {
            return blogrp.Find(x => x.BlogID == getid);
        }

        public int UpdateBlogBLayer(Blog b)
        {
            Blog blog = blogrp.Find(x => x.BlogID == b.BlogID);
            blog.BlogHeader = b.BlogHeader;
            blog.BlogDetail = b.BlogDetail;
            blog.BlogDate = b.BlogDate;
            blog.BlogImage = b.BlogImage;
            blog.CategoriesID = b.CategoriesID;
            blog.WriterID = b.WriterID;
            return blogrp.Update(blog);
        }
    }
}
