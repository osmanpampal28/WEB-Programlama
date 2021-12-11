using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmailSubscribe
    {
        [Key]
        public int EmailID { get; set; }

        [StringLength(60)]
        public string EmailValue { get; set; }

    }
}
