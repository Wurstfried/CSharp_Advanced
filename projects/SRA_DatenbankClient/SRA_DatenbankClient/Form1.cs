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
    public partial class Form1 : Form
    {

        DatenEntities db;
        BindingList<Mitarbeiter> mitarbeiterliste;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (var db = new DatenEntities())
            //{
            //    mitarbeiterlisteListBox.DataSource = db.Mitarbeiter.ToList();
            //}

            db = new DatenEntities();
            mitarbeiterliste = new BindingList<Mitarbeiter>(db.Mitarbeiter.ToList());
            mitarbeiterlisteListBox.DataSource = mitarbeiterliste;
        }

        private void mitarbeiterhinzufügenButton_Click(object sender, EventArgs e)
        {
            MitarbeiterForm form = new MitarbeiterForm();
            form.Mitarbeiter.Personalnummer = db.Mitarbeiter.Max(x => x.Personalnummer) + 1;
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Mitarbeiter.Add(form.Mitarbeiter);
                db.SaveChanges();
                mitarbeiterliste.Add(form.Mitarbeiter);
            }
        }

        private void mitarbeiterentfernenButton_Click(object sender, EventArgs e)
        {
            db.Mitarbeiter  .Remove(mitarbeiterlisteListBox.SelectedItem as Mitarbeiter);
            mitarbeiterliste.Remove(mitarbeiterlisteListBox.SelectedItem as Mitarbeiter);
            db.SaveChanges();
        }

        private void mitarbeiterlisteListBox_DoubleClick(object sender, EventArgs e)
        {
            MitarbeiterForm form = new MitarbeiterForm();
            form.Mitarbeiter = (mitarbeiterlisteListBox.SelectedItem as Mitarbeiter).GetKopie();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var m = db.Mitarbeiter.Where(x => x.Personalnummer == form.Mitarbeiter.Personalnummer).FirstOrDefault();
                m.ÜbertrageWerteVon(form.Mitarbeiter);
                mitarbeiterliste[mitarbeiterlisteListBox.SelectedIndex] = form.Mitarbeiter;
                db.SaveChanges();
            }
        }
    }
}
