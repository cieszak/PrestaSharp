using System.Collections.Generic;
using System.Linq;
using Bukimedia.PrestaSharp.Entities.AuxEntities;

namespace Bukimedia.PrestaSharp.Helpers
{
    public static class LanguageHelper
    {
        public static string GetString(this IEnumerable<language> languageValues)
        {
            return string.Join("/", languageValues.Select(n => n.Value));
        }

        public static string GetValue(this IEnumerable<language> languageValues, long langId)
        {
            return languageValues.Where(n => n.id == langId).Select(n => n.Value).FirstOrDefault();
        }
    }
}
