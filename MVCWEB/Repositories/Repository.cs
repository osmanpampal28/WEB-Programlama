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
        //Context cnt = new Context();

        //public DbSet<OBJ> nesne;

        ////public Repository()
        ////{
        ////    nesne = cnt.Set<OBJ>();  // Context uzerinden gonderdigimiz sinifi obj'ye atama.
        ////}
        //public void Delete(OBJ prm)
        //{
        //    cnt.Set<OBJ>().Remove(prm);
        //    cnt.SaveChanges();
        //}

        //public OBJ Find(Expression<Func<OBJ, bool>> filter)
        //{
        //    return nesne.FirstOrDefault(filter);
        //}

        //public void Get(int id)
        //{
        //    cnt.Set<OBJ>().Find(id);

        //}

        //public void Insert(OBJ prm)
        //{
        //    cnt.Set<OBJ>().Add(prm);
        //    cnt.SaveChanges();
        //}

        //public List<OBJ> List()
        //{
        //    return nesne.ToList();
        //}

        //public List<OBJ> List(Expression<Func<OBJ, bool>> where)
        //{
        //    return nesne.Where(where).ToList();
        //}

        //public void Update(OBJ prm)
        //{
        //    cnt.Set<OBJ>().Update(prm);
        //    cnt.SaveChanges();
        //}
    }
}
