using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlCategories
    {
        Repository<Categories> rps_C = new Repository<Categories>();

        public List<Categories> List_All()
        {
            return rps_C.List();  // repositoryCategories
        }
    }
}
