using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<OBJ>
    {
        List<OBJ> List();
        int Update(OBJ prm);   // create parametres with current Table
        int Insert(OBJ prm);
        int Delete(OBJ prm);
        OBJ GetByID(int id);

        List<OBJ> List(Expression<Func<OBJ, bool>> where);

        OBJ Find(Expression<Func<OBJ, bool>> filter);
    }
}
