using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MVCWEB.Repositories
{
    public interface IRepository<OBJ>
    {
        List<OBJ> List();
        void Update(OBJ prm);   // create parametres with current Table
        void Insert(OBJ prm);
        void Delete(OBJ prm);
        void Get(int id);

        //List<OBJ> List(Expression<Func<OBJ, bool>> where);

        //OBJ Find(Expression<Func<OBJ, bool>> filter);

    }
}
