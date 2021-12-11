using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlWriter
    {
        Repository<Writer> writerrp = new Repository<Writer>();

        // degerleri listeleme
        public List<Writer> ListAll()
        {
            return writerrp.List();
        }
    }
}
