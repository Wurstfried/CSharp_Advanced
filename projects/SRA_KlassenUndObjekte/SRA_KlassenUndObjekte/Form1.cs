using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SRA_KlassenUndObjekte
{
    public partial class Form1 : Form
    {
        BindingList<Mitarbeiter> mitarbeiterliste;
        string dateiname = @"c:\kurs\daten.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void objektErzeugenButton_Click(object sender, EventArgs e)
        {
            Person person;
            person           = new Person();
            person.Anrede    = Anrede.Herr ;
            person.Vorname   = "Wolfgang"  ;
            person.Nachname  = "Petry"     ;
            person.Anzeigen  ( )           ;
            Console.WriteLine( )           ;
        }

        private void personenlisteErzeugenButton_Click(object sender, EventArgs e)
        {
            List<Person> personenliste = new List<Person>();

            Person p1                  ;
            p1           = new Person();
            p1.Anrede    = Anrede.Herr ;
            p1.Vorname   = "Wolfgang"  ;
            p1.Nachname  = "Ambros"    ;
            personenliste.Add(p1)      ;

            Person p2    = new Person();
            p2.Anrede    = Anrede.Herr ;
            p2.Vorname   = "Hans"      ;
            p2.Nachname  = "Gustav"    ;
            personenliste.Add(p2)      ;

            Person p3    = new Person() { Anrede = Anrede.Herr, Vorname = "Hubert", Nachname = "von Goisern" };
            personenliste.Add(p3)      ;

            Person p4    = new Person(Anrede.Herr, "Gunther", "Gunther");
            personenliste.Add(p4)      ;

            personenliste.Add(new Person(Anrede.Frau, "Guntrud", "Gunther"));
            personenlisteListBox.DataSource = personenliste;
        }

        /// <summary>
        /// Protected: Available for class and children.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mitarbeiterlisteErzeugenButton_Click(object sender, EventArgs e)
        {
            mitarbeiterliste = new BindingList<Mitarbeiter>();
            mitarbeiterliste.Add(new Mitarbeiter(1, Anrede.Frau, "Claudia" , "Johmann"));
            mitarbeiterliste.Add(new Mitarbeiter(2, Anrede.Herr, "Wolfgang", "Petry"  , new DateTime(1990, 12, 24)));
            mitarbeiterliste.Add(new Mitarbeiter(3, Anrede.Herr, "Wolfgang", "Ambros" , "17.11.1988"));
            mitarbeiterliste.Add(new Mitarbeiter(4, Anrede.Frau, "Gabi"    , "Maier"  , "02.01.1956"));
            mitarbeiterliste.Add(new Mitarbeiter(5, Anrede.Herr, "Peter"   , "Zwegert", "25.11.1989"));
            mitarbeiterliste.Add(new Mitarbeiter(6, Anrede.Herr, "Hans"    , "Dampf"  , "12.06.1988"));

            StelleDatenbindungHer();
        }

        private void StelleDatenbindungHer()
        {
            mitarbeiterlisteListBox.DataSource = mitarbeiterliste;
            //PersonalnummerTextBox.DataBindings.Add("Text", mitarbeiterliste, "Personalnummer");
            //anredeTextBox        .DataSource = Enum.GetNames(typeof(Anrede));
            personalnummerTextBox.DataBindings.Add("Text", mitarbeiterliste, nameof(Mitarbeiter.Personalnummer), true, DataSourceUpdateMode.OnPropertyChanged);
            anredeTextBox        .DataBindings.Add("Text", mitarbeiterliste, nameof(Mitarbeiter.Anrede)        , true, DataSourceUpdateMode.OnPropertyChanged);
            vornameTextBox       .DataBindings.Add("Text", mitarbeiterliste, nameof(Mitarbeiter.Vorname)       , true, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox      .DataBindings.Add("Text", mitarbeiterliste, nameof(Mitarbeiter.Nachname)      , true, DataSourceUpdateMode.OnPropertyChanged);
            geburtsdatumTextBox  .DataBindings.Add("Text", mitarbeiterliste, nameof(Mitarbeiter.Geburtsdatum)  , true, DataSourceUpdateMode.OnPropertyChanged);
            mitarbeiterlisteErzeugenButton.Enabled = false;
            //Type t = typeof(Mitarbeiter);
            //foreach (var item in t.GetProperties())
            //{
            //    feldnamenComboBox.Items.Add(item.Name);
            //}
            feldnamenComboBox.DataSource = typeof(Mitarbeiter).GetProperties().Select(x => x.Name).ToList();
        }

        private void MitarbeiterentfernenButton_Click(object sender, EventArgs e)
        {
//          mitarbeiterliste.RemoveAt(mitarbeiterlisteListBox.SelectedIndex);
//          mitarbeiterliste.Remove  ((Mitarbeiter)mitarbeiterlisteListBox.SelectedItem);     Type mismatch: Exception
            mitarbeiterliste.Remove  (mitarbeiterlisteListBox.SelectedItem as Mitarbeiter); //Type mismatch: Null
        }

        private void MitarbeiterhinzufügenButton_Click(object sender, EventArgs e)
        {
            //mitarbeiterliste.AddNew();
            //mitarbeiterlisteListBox.SelectedIndex = mitarbeiterlisteListBox.Items.Count - 1;
            //personalnummerTextBox.Text = (mitarbeiterliste.Max(x => x.Personalnummer) + 1).ToString();
            MitarbeiterForm form = new MitarbeiterForm();
            if (form.ShowDialog() == DialogResult.OK)
                {
                mitarbeiterliste.Add(form.Mitarbeiter);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serialisierer = new XmlSerializer(mitarbeiterliste.GetType());
            StreamWriter  schreiber     = new StreamWriter (dateiname                 ); //@"string": String does not contain öh sonderzeichen
            serialisierer.Serialize     ( schreiber, mitarbeiterliste);
            schreiber.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer deserialisierer = new XmlSerializer(typeof(BindingList<Mitarbeiter>));
                using (StreamReader leser = new StreamReader(dateiname))
                {
                    mitarbeiterliste = deserialisierer.Deserialize(leser) as BindingList<Mitarbeiter>;
                    leser.Close();

                }
                StelleDatenbindungHer();
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Es gab da einen Fehler!");
            //}
            catch (FileNotFoundException)
            {
                string msg = "Die Datei " + dateiname + " ist nicht vorhanden. Bitte prüfen Sie den Pfad...\n"
                           + "Alternativ können Sie mit der Funktion \"Mitarbeiterliste erzeugen\" neue Musterdaten anlegen lassen.";
                MessageBox.Show(msg, "Fehler beim Starten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                string msg = "Beim Einlesen der Datei \"" + dateiname + "\" gab es einen Fehler. Die Meldung lautet '"
                           + ex.Message + "'\nSie können mit der Funktion \"Mitarbeiterliste erzeugen\" neue Musterdaten anlegen lassen.";
                MessageBox.Show(msg, "Fehler beim Starten", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es gab da einen Fehler!\nMeldung: " + ex.Message);
            }
        }

        private void mitarbeiterlisteListBox_DoubleClick(object sender, EventArgs e)
        {
            MitarbeiterForm form = new MitarbeiterForm();
//          form.Mitarbeiter     = (mitarbeiterlisteListBox.SelectedItem as Mitarbeiter)  .GetKopie();
            form.Mitarbeiter     = mitarbeiterliste[mitarbeiterlisteListBox.SelectedIndex].GetKopie();
            if (form.ShowDialog() == DialogResult.OK)
            {
                mitarbeiterliste[mitarbeiterlisteListBox.SelectedIndex] = form.Mitarbeiter;
            }
            //form.ShowDialog();
        }

        private void feldwerteanzeigenButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(mitarbeiterliste.ToEigenschaftswerteToString(feldnamenComboBox.Text, "; "));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
