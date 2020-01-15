using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SRA_KlassenUndObjekte
{
    public static class Erweiterungsmethoden
    {
        public static string ToEigenschaftswerteToString<T>(this IEnumerable<T> liste, string eigenschaftsname, string trennzeichen)
        {
            PropertyInfo eigenschaft = typeof(T).GetProperty(eigenschaftsname);
            if (eigenschaft != null)
            {
                StringBuilder ergebnis = new StringBuilder();
                foreach (var item in liste)
                {
                    if (ergebnis.Length > 0)
                    {
                        ergebnis.Append(trennzeichen);
                    }
                    ergebnis.Append(string.Format("{0}", eigenschaft.GetValue(item)));
                }

                return ergebnis.ToString();
            }
            throw new ArgumentException("Die Eigenschaft '" + eigenschaftsname + "' ist nicht vorhanden!");
        }
    }
}
