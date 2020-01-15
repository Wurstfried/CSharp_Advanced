using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRA_KlassenUndObjekte
{
    public class Mitarbeiter : Person
    {
        #region Constructors

        public Mitarbeiter(){}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personalnummer">Personal identification</param>
        /// <param name="anrede"></param>
        /// <param name="nachname"></param>
        public Mitarbeiter(int personalnummer, Anrede anrede, string vorname, string nachname)
            : base (anrede, vorname, nachname)
        {
            Personalnummer = personalnummer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personalnummer"></param>
        /// <param name="anrede"></param>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="geburtsdatum"></param>
        public Mitarbeiter(int personalnummer, Anrede anrede, string vorname, string nachname, DateTime geburtsdatum)
            : this(personalnummer, anrede, vorname, nachname)
        {
            Geburtsdatum = geburtsdatum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personalnummer"></param>
        /// <param name="anrede"></param>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="geburtsdatum"></param>
        public Mitarbeiter(int personalnummer, Anrede anrede, string vorname, string nachname, string geburtsdatum)
            : this(personalnummer, anrede, vorname, nachname)
        {
            //Geburtsdatum = Convert.ToDateTime(geburtsdatum);  // Might cause an exception
            DateTime temp;
            if (DateTime.TryParse(geburtsdatum, out temp))  // out: has to be announced, basically FYI that the var might change
            {
                Geburtsdatum = temp;
            }
        }

        #endregion

        #region Properties
        private int personalnummer;

        /// <summary>
        /// Unique personal number of mitarbeiter
        /// </summary>
        public int Personalnummer
        {
            get { return personalnummer; }
            set
            { 
                if (personalnummer != value)
                {
                    personalnummer = value;
                    LösePropertyChangedEreignisAus();
                }
            }
        }

        private DateTime? geburtsdatum;

        /// <summary>
        /// Date of birth
        /// </summary>
        /// <remarks>
        /// Das Fragezeichen hinter dem Datentyp sorgt dafür, dass die Eigenschaft nun auch
        /// explizit Null sein kann.
        /// </remarks>
        public DateTime? Geburtsdatum
        {
            get { return geburtsdatum; }
            set
            { 
                if (geburtsdatum != value)
                {
                    geburtsdatum = value;
                    LösePropertyChangedEreignisAus();
                } }
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            if (Geburtsdatum.HasValue)
            {
                return string.Format("[{0:0000}] {1} {2:d}", Personalnummer, base.ToString(), Geburtsdatum); 
            }
            return string.Format("[{0:0000}] {1}", Personalnummer, base.ToString());

        }

        /// <summary>
        /// Flache Kopie: nur strings, int, etc. 
        /// Tiefe Kopie: z.B. Serialisieren. GIDF
        /// </summary>
        /// <returns>Eine neue Instanz der Klasse mit den übertragenen Werten der Eigenschaften</returns>
        internal Mitarbeiter GetKopie()
        {
            return this.MemberwiseClone() as Mitarbeiter;
        }
        #endregion
    }
}
