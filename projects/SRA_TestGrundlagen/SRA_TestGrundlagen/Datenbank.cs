using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRA_TestGrundlagen
{
    public class Datenbank
    {

        bool offen = false;
        public bool ÖffneVerbindung(string verbindungszeichenfolge)
        {
            offen = verbindungszeichenfolge.Length > 5;
            return offen;
        }


    }
}
