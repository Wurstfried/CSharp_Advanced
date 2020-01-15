using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SRA_KlassenUndObjekte
{

    /// <summary>
    /// Provides properties and methods to maintain a person
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        #region Constructors
        /// <summary>
        /// Creates an instance of the class and retourns a reference of it
        /// </summary>
        
        public Person(){}

        /// <summary>
        /// Creates an instance of the class and retourns a reference of it
        /// </summary>
        /// <param name="anrede"  >Die Anrede  </param>
        /// <param name="vorname" >Der Vorname </param>
        /// <param name="nachname">Der Nachname</param>
        public Person(Anrede anrede, string vorname, string nachname)
        {
            Anrede   = anrede  ;
            Vorname  = vorname ;
            Nachname = nachname;
        }
        #endregion

        #region Properties
        private string vorname;

        /// <summary>
        /// Name of person
        /// </summary>
        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                if (vorname != value)
                {
                    vorname = value;
                    LösePropertyChangedEreignisAus();
                }
            }
        }

        private string nachname;

        /// <summary>
        /// Surname of person
        /// </summary>
        public string Nachname
        {
            get { return nachname ; }
            set
            { 
                if (nachname != value)
                {
                    nachname = value;
                    LösePropertyChangedEreignisAus();
                }
            }
        }

        private Anrede anrede;

        /// <summary>
        /// Die Anrede der Person
        /// </summary>
        /// <remarks>
        /// Data type of property is an Enum <seealso cref="SRA_KlassenUndObjekte.Anrede"/>
        /// Dort werden die möglichen Werte definiert.
        /// </remarks>
        public Anrede Anrede
        {
            get { return anrede ; }
            set { anrede = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Zeigt die Werte der Eigenschaften in einer Messagebox am Bildschirm an
        /// </summary>
        internal void Anzeigen()
        {
            System.Windows.Forms.MessageBox.Show(Vorname + " " + Nachname);
        }

        /// <summary>
        /// Erzeugt einen String mit den Werten der Eigenschaften und liefert diesen zurück
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Anrede, Vorname, Nachname);
        }
        #endregion

        #region INotifyPropertyChanged-Implementierung

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eigenschaftsname">="" makes it optional</param>
        protected void LösePropertyChangedEreignisAus([CallerMemberName]string eigenschaftsname="")
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(eigenschaftsname));
            //}

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(eigenschaftsname));
        }

        #endregion
    }

    /// <summary>
    /// Definiert mögliche Werte für eine Anrede einer Person.
    /// </summary>
    public enum Anrede
    {
        /// <summary>
        /// Eine Person weiblichen Geschlechts
        /// </summary>
        Frau,
        /// <summary>
        /// Eine Person männlichen Geschlechts
        /// </summary>
        Herr
    }
}
