using LK2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Repositories
{
    public interface ILanguageRepository
    {
        List<Language> GetList();

        Language GetLanguage(Guid languageID);

        void CreateLanguage(Language language);

        void DeleteLanguage(Language language);
    }
}
