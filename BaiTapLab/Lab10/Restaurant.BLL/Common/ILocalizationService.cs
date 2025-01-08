using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Common
{
    public interface ILocalizationService
    {
        string FormatCurrency(decimal amount);

        string Translate(string key);

        string GetCurrentLanguage();

        void SetLanguage(string languageCode);

        Dictionary<string, string> GetAllTranslations();
    }
}
