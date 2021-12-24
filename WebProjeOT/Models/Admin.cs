using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjeOT.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [StringLength(30)]
        public string User { get; set; }  // kullanici

        [StringLength(30)]
        public string Password { get; set; }  // sifre
        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
