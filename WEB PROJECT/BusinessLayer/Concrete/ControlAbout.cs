using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlAbout
    {
        Repository<About> blogrp = new Repository<About>();

        // degerleri listeleme
        public List<About> ListAll()
        {
            return blogrp.List();
        }
    }
}
