using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Persistence.Domain;

namespace Persistence.Repository
{
    public abstract class Repository<T> where T : class, IEntry
    {
        private readonly PropertyInfo context;

        protected Repository(string setName)
        {
            context = typeof(KandandaDbContext).GetProperty(setName);
        }
        
        public List<T> GetAll()
        {
            using (var db = new KandandaDbContext())
            {
                var set = GetDbSet(db);

                return set
                        .Select(entry => entry)
                        .ToList();
            }
        }

        public void DeleteAll()
        {
            foreach (var entry in GetAll())
            {
                DeleteEntry(entry);
            }
        }

        public void DeleteEntry(T entry)
        {
            using (var db = new KandandaDbContext())
            {
                var set = GetDbSet(db);
                set.Remove(entry);
            }
        }

        public T GetEntryById(int id)
        {
            using (var db = new KandandaDbContext())
            {
                var set = GetDbSet(db);

                return set
                    .FirstOrDefault(entry => entry.Id == id);
            }
        }


        public void Save(T entry)
        {
            using (var db = new KandandaDbContext())
            {
                var set = GetDbSet(db);
                
                if (entry.Id != 0)
                {
                    T originalEntry = GetEntryById(entry.Id);
                    db.Entry(originalEntry).CurrentValues.SetValues(entry);
                }
                else
                {
                    set.Add(entry);
                }

                db.SaveChanges();
            }
        }

        private DbSet<T> GetDbSet(KandandaDbContext db)
        {
            return (DbSet<T>) context.GetValue(db);
        }
    }
}
