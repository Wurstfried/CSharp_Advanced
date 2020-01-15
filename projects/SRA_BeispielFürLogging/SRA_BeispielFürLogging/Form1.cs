using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA_BeispielFürLogging
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger("ErsterTest");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//          BasicConfigurator.Configure(); To output in VS Output
            XmlConfigurator  .Configure();
            log.Debug("Anwendung wurde gestartet!");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            log.DebugFormat("Die Maus hat bei {0}/{1} geklickt!", e.X, e.Y);
            //          log.ErrorFormat("Die Maus hat bei {0}/{1} geklickt!", e.X, e.Y);

            try
            {
                if (e.X > e.Y)
                {
                    throw new Exception("X ist größer als Y!!!");
                }
            }
            catch (Exception ex)
            {
                log.Error("Da war ein Fehler!", ex);
            }
        }
    }
}
