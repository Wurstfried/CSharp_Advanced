using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRA_WortspieleServer
{
    public class Wortliste
    {
        #region Private Variablen
        private List<string> kompletteListe;
        #endregion

        #region Constructors

        public Wortliste(string dateiname = @"c:\kurs\wortliste.txt")
        {
            kompletteListe = new List<string>();
            kompletteListe.AddRange(File.ReadAllLines(dateiname)); // = open, read, close
        }

        #endregion

        #region Properties

        public BindingList<string> Wörter
        {
            get
            {
                return new BindingList<string>(kompletteListe.Where(x =>
                            x.Length     >= Mindestlänge
                            && x.Length  <= Maximallänge
                            && x.Contains(  EnthalteneZeichenfolge, GroßkleinschreibungBeachten)).ToList());
            }
        }

        private string enthalteneZeichenfolge = "";

        public string EnthalteneZeichenfolge
        {
            get { return enthalteneZeichenfolge; }
            set { enthalteneZeichenfolge = value; }
        }

        private int mindestlänge = 0;

        public int Mindestlänge
        {
            get { return mindestlänge = 0; }
            set { mindestlänge = value; }
        }

        private int maximallänge = 99;

        public int Maximallänge
        {
            get { return maximallänge; }
            set { maximallänge = value; }
        }

        public bool GroßkleinschreibungBeachten { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
