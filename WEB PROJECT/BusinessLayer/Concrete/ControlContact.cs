using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlContact
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact con)
        {
            if(con.Email=="" || con.Message=="" || con.Subject=="" || con.Name=="" 
                || con.SName=="" || con.Email.Length<=10 || con.Subject.Length <= 3)
            {
                return -1;
            }
            return repocontact.Insert(con);
        }
    }
}
