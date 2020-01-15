using SRA_WortspieleServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA_Wortspiele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Wortliste wortliste = new Wortliste();
//          wörterListBox.DataSource = wortliste.Wörter;
            wörterListBox                .DataBindings.Add("DataSource", wortliste, "Wörter");
            enthaltenezeichenfolgeTextBox.DataBindings.Add("Text"      , wortliste, nameof(Wortliste.EnthalteneZeichenfolge)     , true, DataSourceUpdateMode.OnPropertyChanged);
            mindestlängeTextBox          .DataBindings.Add("Value"     , wortliste, nameof(Wortliste.Mindestlänge)               , true, DataSourceUpdateMode.OnPropertyChanged);
            maximallängeTextBox          .DataBindings.Add("Value"     , wortliste, nameof(Wortliste.Maximallänge)               , true, DataSourceUpdateMode.OnPropertyChanged);
            großKleinschreibungCheckBox  .DataBindings.Add("Checked"   , wortliste, nameof(Wortliste.GroßkleinschreibungBeachten), true, DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
