using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iq007.Filter
{
    class ContainTextFilterCreator
    {
        /// <summary>
        /// First String param is search text
        /// Second String param is item text
        /// </summary>
        /// <returns></returns>
        static public Func<String, String, bool> CreateFilter()
        {
            return new Func<String, String, bool>((searchText, itemText) => {
                if (searchText == null || searchText == String.Empty)
                {
                    return true;
                }
                if (itemText == null || itemText == String.Empty)
                {
                    return true;
                }

                var baseSearchText = searchText.ToLower();
                var baseItemText = itemText.ToLower();

                return baseItemText.Contains(baseSearchText);
            });
        }
    }
}
