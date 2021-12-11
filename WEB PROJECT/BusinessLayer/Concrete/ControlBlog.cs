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
    }
}
