using SRA_Steuerelemente.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRA_Steuerelemente
{
    public partial class Form1 : Form
    {
        private string allowedChars = "0123456789 /-+()\b";

        public Form1()
        {
            InitializeComponent();
        }

        private void beendenButton_Click(object sender, EventArgs e)
        {
            BeendeProgramm();
        }

        private static void BeendeProgramm()
        {
            Application.Exit();
        }

        private void telefonTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("telefonTextBox_KeyDown" );
        }

        private void telefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("telefonTextBox_KeyPress");
            Console.WriteLine(e.KeyChar);
            if (!allowedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telefonTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("telefonTextBox_KeyUp"   );
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e) //123223
        {
            Console.WriteLine("telefonTextBox_TextChanged");
            string result = "";
            foreach (var item in telefonTextBox.Text.ToCharArray())
            {
                if (allowedChars.Contains(item))
                {
                    result += item;
                }
            }
            telefonTextBox.Text = result;
        }
        

        private void auchBeendenLabel_Click(object sender, EventArgs e)
        {
            BeendeProgramm();
        }

        private void auchBeendenLabel_MouseEnter(object sender, EventArgs e)
        {
            auchBeendenLabel.Font = new Font(auchBeendenLabel.Font, FontStyle.Bold);
        }

        private void auchBeendenLabel_MouseLeave(object sender, EventArgs e)
        {
            auchBeendenLabel.Font = new Font(auchBeendenLabel.Font, FontStyle.Regular);

        }

        private void uhrzeitAnzeigenTimer_Tick(object sender, EventArgs e)
        {
            UhrzeitAnzeigenLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void blauRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void GrünRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
        }

        private void RotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Salmon;
        }

        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void englischRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Control startElement = this;
            TauscheSprache(startElement);
        }

        private static void TauscheSprache(Control startElement)
        {
            foreach (Control item in startElement.Controls)
            {
                if (item.Tag != null)
                {
                    string temp = item.Tag.ToString();
                    item.Tag = item.Text;
                    item.Text = temp;

                }
                TauscheSprache(item);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (deutschRadioButton.Checked)
            //{
            //    Settings.Default.Sprache = "Deutsch";
            //}
            //else
            //{
            //    Settings.Default.Sprache = "Englisch";
            //}
            Settings.Default.Sprache          = deutschRadioButton.Checked ? "Deutsch" : "Englisch";
            Settings.Default.Hintergrundfarbe = hintergrundfarbeGroupBox.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault().Name;
            Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            englischRadioButton.Checked = Settings.Default.Sprache == "Englisch";
            if (!string.IsNullOrEmpty(Settings.Default.Hintergrundfarbe))
            {
                ((RadioButton)hintergrundfarbeGroupBox.Controls[Settings.Default.Hintergrundfarbe]).Checked = true;
            }
        }

        private void UhrzeitAnzeigenLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
