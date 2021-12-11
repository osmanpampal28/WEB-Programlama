using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext   // code first  migration
    {
        // Db set kullanarak siniflari DB ye yansitmak

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Categories> CategorieS { get; set; }
        public DbSet<Comments> CommentS { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; } 
        public DbSet<EmailSubscribe> EmailSubscribes { get; set; } 

    }
}
