using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments // yorumlar sinifi.
    {

        [Key]
        public int CommentsID { get; set; }

        [StringLength(60)]
        public string UserN { get; set; }  // userName

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(250)]
        public string CommentDetail { get; set; }

        public DateTime CommentDate { get; set; }

        public bool CommentStatus { get; set; }


        // Comments - Blog  Iliski 
        public int BlogID { get; set; }
        public virtual Blog Blogs { get; set; }

    }
}
