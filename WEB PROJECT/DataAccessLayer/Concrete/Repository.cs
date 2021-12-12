using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Generic Repository
    // implementation  islemleri 
    // IRepository de  tanimladigimiz siniflarin govdeleri
    public class Repository<OBJ> : IRepository<OBJ> where OBJ : class
    {
        Context cnt = new Context();
        DbSet<OBJ> obj;

        // kurucu method
        public Repository()
        {
            obj = cnt.Set<OBJ>();  // Context uzerinden gonderdigimiz sinifi obj'ye atama.
        }
        public int Delete(OBJ prm)
        {
            obj.Remove(prm);  // parametreden gelen degerini silmek
            return cnt.SaveChanges();
        }

        public OBJ Find(Expression<Func<OBJ, bool>> filter)
        {
            return obj.FirstOrDefault(filter);
        }

        public OBJ GetByID(int id)
        {
            return obj.Find(id);
        }

        public int Insert(OBJ prm)
        {
            obj.Add(prm);
            return cnt.SaveChanges();
        }

        public List<OBJ> List()
        {
            return obj.ToList();
        }

        public List<OBJ> List(Expression<Func<OBJ, bool>> where)
        {
            return obj.Where(where).ToList();
        }

        public int Update(OBJ prm)
        {
            return cnt.SaveChanges();
        }
    }
}
