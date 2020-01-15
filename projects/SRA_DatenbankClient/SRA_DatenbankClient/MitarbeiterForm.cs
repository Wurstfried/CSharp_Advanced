using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA_DatenbankClient
{
    public partial class MitarbeiterForm : Form
    {
        public MitarbeiterForm()
        {
            InitializeComponent();
        }

        public Mitarbeiter Mitarbeiter { get; set; } = new Mitarbeiter();

        private void MitarbeiterForm_Load(object sender, EventArgs e)
        {
            anredeComboBox.DataSource = new string []{ "Herr", "Frau"}; 
            personalnummerTextBox.DataBindings.Add("Text", Mitarbeiter, nameof(SRA_DatenbankClient.Mitarbeiter.Personalnummer), true, DataSourceUpdateMode.OnPropertyChanged);
            anredeComboBox       .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_DatenbankClient.Mitarbeiter.Anrede)        , true, DataSourceUpdateMode.OnPropertyChanged);
            vornameTextBox       .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_DatenbankClient.Mitarbeiter.Vorname)       , true, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox      .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_DatenbankClient.Mitarbeiter.Nachname)      , true, DataSourceUpdateMode.OnPropertyChanged);
            geburtsdatumTextBox  .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_DatenbankClient.Mitarbeiter.Geburtsdatum)  , true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}