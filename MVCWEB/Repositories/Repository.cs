using Microsoft.EntityFrameworkCore;
using MVCWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MVCWEB.Repositories
{
    public class Repository<OBJ> : IRepository<OBJ> where OBJ : class
    {
        Context cnt = new Context();
        //DbSet<OBJ> obj;


        //public Repository()
        //{
        //    obj = cnt.Set<OBJ>();  // Context uzerinden gonderdigimiz sinifi obj'ye atama.
        //}
        public void Delete(OBJ prm)
        {
            cnt.Set<OBJ>().Remove(prm);
            cnt.SaveChanges();
        }

        //public OBJ Find(Expression<Func<OBJ, bool>> filter)
        //{
        //    return obj.FirstOrDefault(filter);
        //}

        public void Get(int id)
        {
            cnt.Set<OBJ>().Find(id);
           
        }

        public void Insert(OBJ prm)
        {
            cnt.Set<OBJ>().Add(prm);
            cnt.SaveChanges();
        }

        public List<OBJ> List()
        {
            return cnt.Set<OBJ>().ToList();
        }

        //public List<OBJ> List(Expression<Func<OBJ, bool>> where)
        //{
        //    return obj.Where(where).ToList();
        //}

        public void Update(OBJ prm)
        {
            cnt.Set<OBJ>().Update(prm);
            cnt.SaveChanges();
        }
    }
}
