using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Categories
    {
        [Key]
        public int CategoriesID { get; set; }

        //kisitlama ekleme  50-den fazla karakter olmaz.



        // Categories  -  Blog Iliski

        [StringLength(30)]
        public string CategoriesName { get; set; }

        [StringLength(500)]
        public string CategoryDescription { get; set; }
        public ICollection<Blog> Blog { get; set; } // Categories  ve Blog siniflar arasinda iliski kurmak.

    }
}
