using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {

        [Key]
        public int WriterID { get; set; }   // unique ID 

        [StringLength(60)]
        public string WriterN_S { get; set; } // yazarin Ad ve Soyad

        [StringLength(300)]
        public string WriterAbout { get; set; } // yazarin hakkinda bilgiler

        [StringLength(140)]
        public string WriterImage { get; set; } // dosya olarak tutulacak 

        public ICollection<Blog> Blogs { get; set; }  // Blog ve Yazar   iliskisi 
    }
}
