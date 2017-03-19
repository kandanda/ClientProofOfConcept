using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Persistence.Repository
{
    public abstract class Repository<T> where T : class
    {
        private readonly PropertyInfo context;

        protected Repository(string setName)
        {
            context = typeof(KandandaDbContext).GetProperty(setName);
        }
        
        public List<T> GetAll()
        {
            using (KandandaDbContext db = new KandandaDbContext())
            {
                DbSet<T> set = (DbSet<T>) context.GetValue(db);
                return set.Select(entry => entry).ToList();
            }
        }

        public int Save(T entry)
        {
            using (KandandaDbContext db = new KandandaDbContext())
            {
                var dbSet = GetDbSet(db, context);
                dbSet.Add(entry);
                return db.SaveChanges();
            }
        }

        private DbSet<T> GetDbSet(KandandaDbContext db, PropertyInfo context)
        {
            return (DbSet<T>) context.GetValue(db);
        }
    }
}
