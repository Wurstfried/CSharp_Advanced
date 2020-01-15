using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRA_DatenbankClient
{
    public partial class Mitarbeiter
    {
        public override string ToString()
        {
            return string.Format($"{Personalnummer:0000} {Anrede} {Vorname} {Nachname} {Geburtsdatum:d}");
        }

        internal Mitarbeiter GetKopie()
        {
            return MemberwiseClone() as Mitarbeiter;
        }

        internal void ÜbertrageWerteVon(Mitarbeiter mitarbeiter)
        {
            Personalnummer = mitarbeiter.Personalnummer;
            Anrede         = mitarbeiter.Anrede        ;
            Vorname        = mitarbeiter.Vorname       ;
            Nachname       = mitarbeiter.Nachname      ;
            Geburtsdatum   = mitarbeiter.Geburtsdatum  ;
        }
    }
}
