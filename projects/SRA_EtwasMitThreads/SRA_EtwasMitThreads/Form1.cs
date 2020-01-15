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

namespace SRA_EtwasMitThreads
{
    public partial class Form1 : Form
    {
        BackgroundWorker arbeiter;
        //List<string> daten;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abbrechenButton.Enabled             = false;
            arbeiter                            = new BackgroundWorker();
            arbeiter.WorkerReportsProgress      = true;
            arbeiter.WorkerSupportsCancellation = true;
            arbeiter.DoWork                    += Arbeiter_DoWork;
            arbeiter.RunWorkerCompleted        += Arbeiter_RunWorkerCompleted;
            arbeiter.ProgressChanged           += Arbeiter_ProgressChanged;
        }

        private void Arbeiter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            fortschrittProgressBar.Value = e.ProgressPercentage;
        }

        private void Arbeiter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            abbrechenButton.Enabled    = false;
            startenButton  .Enabled    = true ;
            //datenListBox   .DataSource = daten;
            if (e.Cancelled)
            {
                MessageBox.Show("Die Verarbeitung wurde abgebrochen, möglicherweise sind nicht alle Daten geladen!");
            }
            else
            {
                MessageBox.Show("Das war's!");
            }
            fortschrittProgressBar.Value = 0;
        }

        private void Arbeiter_DoWork(object sender, DoWorkEventArgs e)
        {
            string dateiname       = @"c:\kurs\wortliste.txt";
            StreamReader leser     = new StreamReader(dateiname);
            long gesamt            = new FileInfo    (dateiname).Length;
            List<string> templiste = new List<string>();
            long geleseneZeichen   = 0;
            var temparbeiter       = sender as BackgroundWorker;
            while (!leser.EndOfStream && !temparbeiter.CancellationPending)
            {
                string zeile     = leser.ReadLine();
                templiste.Add    ( zeile);
                geleseneZeichen += zeile.Length + 2;
                if (templiste.Count % 1000 == 0)
                {
                    FügeGeleseneZeilenEin(templiste);
                    System.Threading.Thread.Sleep(10);
                    temparbeiter.ReportProgress(Convert.ToInt32(100 * geleseneZeichen / gesamt));
                    templiste.Clear();
                }
                e.Cancel = temparbeiter.CancellationPending;
            }
            leser.Close();
            //daten = templiste;
            FügeGeleseneZeilenEin(templiste);
        }

        private void FügeGeleseneZeilenEin(List<string> templiste)
        {
            if (!InvokeRequired )
            {
                datenListBox.Items.AddRange(templiste.ToArray());
                datenListBox.SelectedIndex = datenListBox.Items.Count - 1;
            }
            else
            {
               Invoke(new MethodInvoker(delegate { FügeGeleseneZeilenEin(templiste); } ));
            }
        }

        private void startenButton_Click(object sender, EventArgs e)
        {
            startenButton.Enabled   = false;
            abbrechenButton.Enabled = true;
            arbeiter.RunWorkerAsync();
        }


        private void abbrechenButton_Click(object sender, EventArgs e)
        {
            arbeiter.CancelAsync();
        }
    }
}
