using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWEB.Models
{
    public class Context : DbContext
    {
        //public Context()
        //{

        //}



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-D0QHIJN;Database=DbYeni;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Categories> CategorieS { get; set; }
        public DbSet<Comments> CommentS { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<EmailSubscribe> EmailSubscribes { get; set; }

        public Context(DbContextOptions<Context> nesne) : base(nesne)
        {
            //nesne.UseSqlServer("server=DESKTOP-D0QHIJN\\SQLEXPRESS; database=DbWeb;integrated security=true ");
        }
    }
}
