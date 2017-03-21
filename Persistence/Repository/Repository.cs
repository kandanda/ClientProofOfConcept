using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Linq;
using Persistence.Domain;

namespace Persistence.Repository
{
    public abstract class Repository<T> where T : class, IEntry
    {
        private readonly IDatabaseContextFactory dbContextFactory;
        private readonly IPluralizationService pluralizationService;

        protected Repository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService)
        {
            this.dbContextFactory = dbContextFactory;
            this.pluralizationService = pluralizationService;
        }

        public List<T> GetAll()
        {
            using (var db = dbContextFactory.Create())
            {
                return GetDbSet(db)
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
            using (var db = dbContextFactory.Create())
            {
                GetDbSet(db).Remove(entry);
            }
        }

        public T GetEntryById(int id)
        {
            using (var db = dbContextFactory.Create())
            {
                return GetDbSet(db)
                    .FirstOrDefault(entry => entry.Id == id);
            }
        }
        
        public void Save(T entry)
        {
            using (var db = dbContextFactory.Create())
            {
                if (entry.Id != 0)
                {
                    var originalEntry = GetEntryById(entry.Id);
                    db.Entry(originalEntry).CurrentValues.SetValues(entry);
                }
                else
                {
                    GetDbSet(db).Add(entry);
                }

                db.SaveChanges();
            }
        }

        private DbSet<T> GetDbSet(DbContext db)
        {
            var pluralizedName = GetPluralizedName();
            var propertyInfo = db.GetType().GetProperty(pluralizedName);
            return (DbSet<T>) propertyInfo.GetValue(db);
        }

        private string GetPluralizedName()
        {
            var className = typeof(T).Name;
            return pluralizationService.Pluralize(className);
        }
    }
}
