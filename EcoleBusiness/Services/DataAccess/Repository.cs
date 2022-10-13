using EcoleBusiness.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleBusiness.Services.DataAccess
{
    internal class Repository
    {
        public IEnumerable<T> GetAll<T>() where T: class
        {
            using var context = new EcoleDbContext();
            return context.Set<T>().ToList();
        }

        public void Insert<T>(T item) where T : class
        {
            using (var dbctx = new EcoleDbContext())
            {
                dbctx.Set<T>().Add(item);

                dbctx.SaveChanges();
            }
        }

        public void Update<T>(T item) where T : class
        {
            using (var dbctx = new EcoleDbContext())
            {
                dbctx.Set<T>().Update(item);

                dbctx.SaveChanges();
            }
        }

        public void Delete<T>(int id) where T : class
        {
            using (var dbctx = new EcoleDbContext())
            {
                var item = dbctx.Set<T>().Find(id);
                if (item != null)
                {
                    dbctx.Set<T>().Remove(item);
                    dbctx.SaveChanges();
                }
            }
        }

        public T GetById<T>(int id) where T: class
        {
            using var _dbctx = new EcoleDbContext();
            return _dbctx.Set<T>().Find(id);
        }

    }
}
