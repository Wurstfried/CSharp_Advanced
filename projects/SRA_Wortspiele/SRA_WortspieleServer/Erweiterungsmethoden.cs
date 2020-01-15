using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRA_WortspieleServer
{
    public static class Erweiterungsmethoden
    {
        public static bool Contains(this string text, string suchtext, bool großKleinschreibungBeachten)
        {
            if (großKleinschreibungBeachten)
            {
                return text.Contains(suchtext);
            }
            //text.ToLower().Contains(suchtesxt.ToLower());
            return text.IndexOf(suchtext, StringComparison.OrdinalIgnoreCase) > -1;
        }
    }
}
