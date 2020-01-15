namespace SRA_Steuerelemente
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.beendenButton = new System.Windows.Forms.Button();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.auchBeendenLabel = new System.Windows.Forms.Label();
            this.UhrzeitAnzeigenLabel = new System.Windows.Forms.Label();
            this.uhrzeitAnzeigenTimer = new System.Windows.Forms.Timer(this.components);
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.RotRadioButton = new System.Windows.Forms.RadioButton();
            this.GrünRadioButton = new System.Windows.Forms.RadioButton();
            this.blauRadioButton = new System.Windows.Forms.RadioButton();
            this.hintergrundfarbeGroupBox = new System.Windows.Forms.GroupBox();
            this.SpracheGroupbox = new System.Windows.Forms.GroupBox();
            this.englischRadioButton = new System.Windows.Forms.RadioButton();
            this.deutschRadioButton = new System.Windows.Forms.RadioButton();
            this.hintergrundfarbeGroupBox.SuspendLayout();
            this.SpracheGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // beendenButton
            // 
            this.beendenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beendenButton.Location = new System.Drawing.Point(311, 12);
            this.beendenButton.Name = "beendenButton";
            this.beendenButton.Size = new System.Drawing.Size(102, 23);
            this.beendenButton.TabIndex = 0;
            this.beendenButton.Tag = "&Exit";
            this.beendenButton.Text = "&Beenden";
            this.beendenButton.UseVisualStyleBackColor = true;
            this.beendenButton.Click += new System.EventHandler(this.beendenButton_Click);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonTextBox.Location = new System.Drawing.Point(113, 14);
            this.telefonTextBox.MaxLength = 40;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(180, 20);
            this.telefonTextBox.TabIndex = 2;
            this.telefonTextBox.TextChanged += new System.EventHandler(this.telefonTextBox_TextChanged);
            this.telefonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telefonTextBox_KeyDown);
            this.telefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonTextBox_KeyPress);
            this.telefonTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.telefonTextBox_KeyUp);
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(33, 17);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(42, 17);
            this.telefonLabel.TabIndex = 1;
            this.telefonLabel.Tag = "&Telephone";
            this.telefonLabel.Text = "&Telefon";
            this.telefonLabel.UseCompatibleTextRendering = true;
            // 
            // auchBeendenLabel
            // 
            this.auchBeendenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auchBeendenLabel.BackColor = System.Drawing.Color.Yellow;
            this.auchBeendenLabel.ForeColor = System.Drawing.Color.Red;
            this.auchBeendenLabel.Location = new System.Drawing.Point(12, 264);
            this.auchBeendenLabel.Name = "auchBeendenLabel";
            this.auchBeendenLabel.Size = new System.Drawing.Size(401, 44);
            this.auchBeendenLabel.TabIndex = 3;
            this.auchBeendenLabel.Tag = "Also exit";
            this.auchBeendenLabel.Text = "Auch beenden";
            this.auchBeendenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.auchBeendenLabel.Click += new System.EventHandler(this.auchBeendenLabel_Click);
            this.auchBeendenLabel.MouseEnter += new System.EventHandler(this.auchBeendenLabel_MouseEnter);
            this.auchBeendenLabel.MouseLeave += new System.EventHandler(this.auchBeendenLabel_MouseLeave);
            // 
            // UhrzeitAnzeigenLabel
            // 
            this.UhrzeitAnzeigenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UhrzeitAnzeigenLabel.BackColor = System.Drawing.Color.Maroon;
            this.UhrzeitAnzeigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.UhrzeitAnzeigenLabel.ForeColor = System.Drawing.Color.Red;
            this.UhrzeitAnzeigenLabel.Location = new System.Drawing.Point(12, 66);
            this.UhrzeitAnzeigenLabel.Name = "UhrzeitAnzeigenLabel";
            this.UhrzeitAnzeigenLabel.Size = new System.Drawing.Size(401, 50);
            this.UhrzeitAnzeigenLabel.TabIndex = 4;
            this.UhrzeitAnzeigenLabel.Text = "00:00:00";
            this.UhrzeitAnzeigenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UhrzeitAnzeigenLabel.Click += new System.EventHandler(this.UhrzeitAnzeigenLabel_Click);
            // 
            // uhrzeitAnzeigenTimer
            // 
            this.uhrzeitAnzeigenTimer.Enabled = true;
            this.uhrzeitAnzeigenTimer.Interval = 1000;
            this.uhrzeitAnzeigenTimer.Tick += new System.EventHandler(this.uhrzeitAnzeigenTimer_Tick);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(23, 19);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.StandardRadioButton.TabIndex = 5;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Tag = "Standard";
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this.StandardRadioButton_CheckedChanged);
            // 
            // RotRadioButton
            // 
            this.RotRadioButton.AutoSize = true;
            this.RotRadioButton.Location = new System.Drawing.Point(23, 46);
            this.RotRadioButton.Name = "RotRadioButton";
            this.RotRadioButton.Size = new System.Drawing.Size(42, 17);
            this.RotRadioButton.TabIndex = 6;
            this.RotRadioButton.Tag = "Red";
            this.RotRadioButton.Text = "Rot";
            this.RotRadioButton.UseVisualStyleBackColor = true;
            this.RotRadioButton.CheckedChanged += new System.EventHandler(this.RotRadioButton_CheckedChanged);
            // 
            // GrünRadioButton
            // 
            this.GrünRadioButton.AutoSize = true;
            this.GrünRadioButton.Location = new System.Drawing.Point(23, 73);
            this.GrünRadioButton.Name = "GrünRadioButton";
            this.GrünRadioButton.Size = new System.Drawing.Size(48, 17);
            this.GrünRadioButton.TabIndex = 7;
            this.GrünRadioButton.Tag = "Green";
            this.GrünRadioButton.Text = "Grün";
            this.GrünRadioButton.UseVisualStyleBackColor = true;
            this.GrünRadioButton.CheckedChanged += new System.EventHandler(this.GrünRadioButton_CheckedChanged);
            // 
            // blauRadioButton
            // 
            this.blauRadioButton.AutoSize = true;
            this.blauRadioButton.Location = new System.Drawing.Point(23, 100);
            this.blauRadioButton.Name = "blauRadioButton";
            this.blauRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blauRadioButton.TabIndex = 8;
            this.blauRadioButton.Tag = "Blue";
            this.blauRadioButton.Text = "Blau";
            this.blauRadioButton.UseVisualStyleBackColor = true;
            this.blauRadioButton.CheckedChanged += new System.EventHandler(this.blauRadioButton_CheckedChanged);
            // 
            // hintergrundfarbeGroupBox
            // 
            this.hintergrundfarbeGroupBox.Controls.Add(this.StandardRadioButton);
            this.hintergrundfarbeGroupBox.Controls.Add(this.blauRadioButton);
            this.hintergrundfarbeGroupBox.Controls.Add(this.RotRadioButton);
            this.hintergrundfarbeGroupBox.Controls.Add(this.GrünRadioButton);
            this.hintergrundfarbeGroupBox.Location = new System.Drawing.Point(12, 119);
            this.hintergrundfarbeGroupBox.Name = "hintergrundfarbeGroupBox";
            this.hintergrundfarbeGroupBox.Size = new System.Drawing.Size(119, 129);
            this.hintergrundfarbeGroupBox.TabIndex = 9;
            this.hintergrundfarbeGroupBox.TabStop = false;
            this.hintergrundfarbeGroupBox.Tag = "&Backcolor";
            this.hintergrundfarbeGroupBox.Text = "&Hintergrundfarbe";
            this.hintergrundfarbeGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SpracheGroupbox
            // 
            this.SpracheGroupbox.Controls.Add(this.englischRadioButton);
            this.SpracheGroupbox.Controls.Add(this.deutschRadioButton);
            this.SpracheGroupbox.Location = new System.Drawing.Point(137, 119);
            this.SpracheGroupbox.Name = "SpracheGroupbox";
            this.SpracheGroupbox.Size = new System.Drawing.Size(276, 129);
            this.SpracheGroupbox.TabIndex = 10;
            this.SpracheGroupbox.TabStop = false;
            this.SpracheGroupbox.Tag = "&Language";
            this.SpracheGroupbox.Text = "&Sprache";
            // 
            // englischRadioButton
            // 
            this.englischRadioButton.AutoSize = true;
            this.englischRadioButton.Location = new System.Drawing.Point(6, 39);
            this.englischRadioButton.Name = "englischRadioButton";
            this.englischRadioButton.Size = new System.Drawing.Size(65, 17);
            this.englischRadioButton.TabIndex = 1;
            this.englischRadioButton.Tag = "English";
            this.englischRadioButton.Text = "Englisch";
            this.englischRadioButton.UseVisualStyleBackColor = true;
            this.englischRadioButton.CheckedChanged += new System.EventHandler(this.englischRadioButton_CheckedChanged);
            // 
            // deutschRadioButton
            // 
            this.deutschRadioButton.AutoSize = true;
            this.deutschRadioButton.Checked = true;
            this.deutschRadioButton.Location = new System.Drawing.Point(6, 16);
            this.deutschRadioButton.Name = "deutschRadioButton";
            this.deutschRadioButton.Size = new System.Drawing.Size(65, 17);
            this.deutschRadioButton.TabIndex = 0;
            this.deutschRadioButton.TabStop = true;
            this.deutschRadioButton.Tag = "German";
            this.deutschRadioButton.Text = "Deutsch";
            this.deutschRadioButton.UseVisualStyleBackColor = true;
            this.deutschRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 317);
            this.Controls.Add(this.SpracheGroupbox);
            this.Controls.Add(this.hintergrundfarbeGroupBox);
            this.Controls.Add(this.UhrzeitAnzeigenLabel);
            this.Controls.Add(this.auchBeendenLabel);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.beendenButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steuerelemente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hintergrundfarbeGroupBox.ResumeLayout(false);
            this.hintergrundfarbeGroupBox.PerformLayout();
            this.SpracheGroupbox.ResumeLayout(false);
            this.SpracheGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beendenButton;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label auchBeendenLabel;
        private System.Windows.Forms.Label UhrzeitAnzeigenLabel;
        private System.Windows.Forms.Timer uhrzeitAnzeigenTimer;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.RadioButton RotRadioButton;
        private System.Windows.Forms.RadioButton GrünRadioButton;
        private System.Windows.Forms.RadioButton blauRadioButton;
        private System.Windows.Forms.GroupBox hintergrundfarbeGroupBox;
        private System.Windows.Forms.GroupBox SpracheGroupbox;
        private System.Windows.Forms.RadioButton deutschRadioButton;
        private System.Windows.Forms.RadioButton englischRadioButton;
    }
}

