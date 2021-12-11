using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key] 
        public int BlogID { get; set; }

        [StringLength(110)]
        public string BlogHeader { get; set; } // baslik


        public string BlogDetail { get; set; }  // blog icerik

        public DateTime BlogDate { get; set; }

        [StringLength(110)]
        public string BlogImage { get; set; }

        //  Blog - Categories
        public int CategoriesID { get; set; }
        public virtual Categories Categories { get; set; }  // Categories  ve Blog siniflar arasinda iliski kuruldu.

        // Blog - Writer
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; } // Her Blogun bir yazari olmali 


        // Blog - Comments
        public ICollection<Comments> Comments { get; set; }






    }
}
