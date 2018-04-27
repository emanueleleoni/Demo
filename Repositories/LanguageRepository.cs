using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LK2.Models;

namespace LK2.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private DatabaseContext db;

        public LanguageRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public void CreateLanguage(Language language)
        {
            db.Languages.Add(language);
            db.SaveChanges();
        }

        public void DeleteLanguage(Language language)
        {
            db.Languages.Remove(language);
            db.SaveChanges();
        }

        public Language GetLanguage(Guid languageID)
        {
            return db.Languages.FirstOrDefault(l => l.LanguageID.Equals(languageID));
        }

        public List<Language> GetList()
        {
            return db.Languages.OrderBy(l => l.Name).ToList();
        }
    }
}
