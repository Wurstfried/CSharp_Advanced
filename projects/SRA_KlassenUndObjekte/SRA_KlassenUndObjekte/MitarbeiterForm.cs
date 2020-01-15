using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA_KlassenUndObjekte
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
            anredeComboBox.DataSource = Enum.GetNames(typeof(Anrede));
            personalnummerTextBox.DataBindings.Add("Text", Mitarbeiter, nameof(SRA_KlassenUndObjekte.Mitarbeiter.Personalnummer), true, DataSourceUpdateMode.OnPropertyChanged);
            anredeComboBox       .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_KlassenUndObjekte.Mitarbeiter.Anrede)        , true, DataSourceUpdateMode.OnPropertyChanged);
            vornameTextBox       .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_KlassenUndObjekte.Mitarbeiter.Vorname)       , true, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox      .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_KlassenUndObjekte.Mitarbeiter.Nachname)      , true, DataSourceUpdateMode.OnPropertyChanged);
            geburtsdatumTextBox  .DataBindings.Add("Text", Mitarbeiter, nameof(SRA_KlassenUndObjekte.Mitarbeiter.Geburtsdatum)  , true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
