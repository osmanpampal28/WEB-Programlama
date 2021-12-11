using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    
    public class ControlEmailSubscribe
    {
        // repoES = repositoryEmailSubscirebe  (bir nesne )
        Repository<EmailSubscribe> repoES = new Repository<EmailSubscribe>();

        public int AddBusinessL(EmailSubscribe prm)
        {
            if (prm.EmailValue.Length  < 11 || prm.EmailValue.Length >=60)
            {
                return -1;
            }
            // eger dogru email girildiyse  ekleme islemini gerceklestir. 
            return repoES.Insert(prm);
        }
    }
}
