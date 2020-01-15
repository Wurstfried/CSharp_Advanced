namespace SRA_KlassenUndObjekte
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
            this.objektErzeugenButton = new System.Windows.Forms.Button();
            this.personenlisteErzeugenButton = new System.Windows.Forms.Button();
            this.personenlisteListBox = new System.Windows.Forms.ListBox();
            this.mitarbeiterlisteListBox = new System.Windows.Forms.ListBox();
            this.mitarbeiterlisteErzeugenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personalnummerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anredeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.geburtsdatumTextBox = new System.Windows.Forms.TextBox();
            this.MitarbeiterhinzufügenButton = new System.Windows.Forms.Button();
            this.MitarbeiterentfernenButton = new System.Windows.Forms.Button();
            this.feldwerteanzeigenButton = new System.Windows.Forms.Button();
            this.feldnamenComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // objektErzeugenButton
            // 
            this.objektErzeugenButton.Location = new System.Drawing.Point(12, 12);
            this.objektErzeugenButton.Name = "objektErzeugenButton";
            this.objektErzeugenButton.Size = new System.Drawing.Size(184, 34);
            this.objektErzeugenButton.TabIndex = 0;
            this.objektErzeugenButton.Text = "&Objekt erzeugen";
            this.objektErzeugenButton.UseVisualStyleBackColor = true;
            this.objektErzeugenButton.Click += new System.EventHandler(this.objektErzeugenButton_Click);
            // 
            // personenlisteErzeugenButton
            // 
            this.personenlisteErzeugenButton.Location = new System.Drawing.Point(12, 52);
            this.personenlisteErzeugenButton.Name = "personenlisteErzeugenButton";
            this.personenlisteErzeugenButton.Size = new System.Drawing.Size(280, 34);
            this.personenlisteErzeugenButton.TabIndex = 1;
            this.personenlisteErzeugenButton.Text = "Personenliste erzeugen";
            this.personenlisteErzeugenButton.UseVisualStyleBackColor = true;
            this.personenlisteErzeugenButton.Click += new System.EventHandler(this.personenlisteErzeugenButton_Click);
            // 
            // personenlisteListBox
            // 
            this.personenlisteListBox.FormattingEnabled = true;
            this.personenlisteListBox.Location = new System.Drawing.Point(12, 92);
            this.personenlisteListBox.Name = "personenlisteListBox";
            this.personenlisteListBox.Size = new System.Drawing.Size(280, 355);
            this.personenlisteListBox.TabIndex = 2;
            // 
            // mitarbeiterlisteListBox
            // 
            this.mitarbeiterlisteListBox.FormattingEnabled = true;
            this.mitarbeiterlisteListBox.Location = new System.Drawing.Point(298, 92);
            this.mitarbeiterlisteListBox.Name = "mitarbeiterlisteListBox";
            this.mitarbeiterlisteListBox.Size = new System.Drawing.Size(280, 355);
            this.mitarbeiterlisteListBox.TabIndex = 4;
            this.mitarbeiterlisteListBox.DoubleClick += new System.EventHandler(this.mitarbeiterlisteListBox_DoubleClick);
            // 
            // mitarbeiterlisteErzeugenButton
            // 
            this.mitarbeiterlisteErzeugenButton.Location = new System.Drawing.Point(298, 52);
            this.mitarbeiterlisteErzeugenButton.Name = "mitarbeiterlisteErzeugenButton";
            this.mitarbeiterlisteErzeugenButton.Size = new System.Drawing.Size(280, 34);
            this.mitarbeiterlisteErzeugenButton.TabIndex = 3;
            this.mitarbeiterlisteErzeugenButton.Text = "Mitarbeiterliste erzeugen";
            this.mitarbeiterlisteErzeugenButton.UseVisualStyleBackColor = true;
            this.mitarbeiterlisteErzeugenButton.Click += new System.EventHandler(this.mitarbeiterlisteErzeugenButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Personalnummer:";
            // 
            // personalnummerTextBox
            // 
            this.personalnummerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personalnummerTextBox.Location = new System.Drawing.Point(724, 78);
            this.personalnummerTextBox.Name = "personalnummerTextBox";
            this.personalnummerTextBox.ReadOnly = true;
            this.personalnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.personalnummerTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "&Anrede:";
            // 
            // anredeTextBox
            // 
            this.anredeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anredeTextBox.Location = new System.Drawing.Point(724, 98);
            this.anredeTextBox.Name = "anredeTextBox";
            this.anredeTextBox.ReadOnly = true;
            this.anredeTextBox.Size = new System.Drawing.Size(100, 20);
            this.anredeTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Vorname:";
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vornameTextBox.Location = new System.Drawing.Point(724, 118);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.ReadOnly = true;
            this.vornameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vornameTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "&Nachname:";
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nachnameTextBox.Location = new System.Drawing.Point(724, 138);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.ReadOnly = true;
            this.nachnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nachnameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "&Geburtsdatum";
            // 
            // geburtsdatumTextBox
            // 
            this.geburtsdatumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.geburtsdatumTextBox.Location = new System.Drawing.Point(724, 158);
            this.geburtsdatumTextBox.Name = "geburtsdatumTextBox";
            this.geburtsdatumTextBox.ReadOnly = true;
            this.geburtsdatumTextBox.Size = new System.Drawing.Size(100, 20);
            this.geburtsdatumTextBox.TabIndex = 14;
            // 
            // MitarbeiterhinzufügenButton
            // 
            this.MitarbeiterhinzufügenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MitarbeiterhinzufügenButton.Location = new System.Drawing.Point(597, 184);
            this.MitarbeiterhinzufügenButton.Name = "MitarbeiterhinzufügenButton";
            this.MitarbeiterhinzufügenButton.Size = new System.Drawing.Size(227, 30);
            this.MitarbeiterhinzufügenButton.TabIndex = 15;
            this.MitarbeiterhinzufügenButton.Text = "&Mitarbeiter hinzufügen";
            this.MitarbeiterhinzufügenButton.UseVisualStyleBackColor = true;
            this.MitarbeiterhinzufügenButton.Click += new System.EventHandler(this.MitarbeiterhinzufügenButton_Click);
            // 
            // MitarbeiterentfernenButton
            // 
            this.MitarbeiterentfernenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MitarbeiterentfernenButton.Location = new System.Drawing.Point(597, 221);
            this.MitarbeiterentfernenButton.Name = "MitarbeiterentfernenButton";
            this.MitarbeiterentfernenButton.Size = new System.Drawing.Size(227, 30);
            this.MitarbeiterentfernenButton.TabIndex = 16;
            this.MitarbeiterentfernenButton.Text = "Mitarbeiter &entfernen";
            this.MitarbeiterentfernenButton.UseVisualStyleBackColor = true;
            this.MitarbeiterentfernenButton.Click += new System.EventHandler(this.MitarbeiterentfernenButton_Click);
            // 
            // feldwerteanzeigenButton
            // 
            this.feldwerteanzeigenButton.Location = new System.Drawing.Point(597, 320);
            this.feldwerteanzeigenButton.Name = "feldwerteanzeigenButton";
            this.feldwerteanzeigenButton.Size = new System.Drawing.Size(227, 30);
            this.feldwerteanzeigenButton.TabIndex = 17;
            this.feldwerteanzeigenButton.Text = "&Feldwerte anzeigen";
            this.feldwerteanzeigenButton.UseVisualStyleBackColor = true;
            this.feldwerteanzeigenButton.Click += new System.EventHandler(this.feldwerteanzeigenButton_Click);
            // 
            // feldnamenComboBox
            // 
            this.feldnamenComboBox.FormattingEnabled = true;
            this.feldnamenComboBox.Location = new System.Drawing.Point(597, 293);
            this.feldnamenComboBox.Name = "feldnamenComboBox";
            this.feldnamenComboBox.Size = new System.Drawing.Size(227, 21);
            this.feldnamenComboBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 550);
            this.Controls.Add(this.feldnamenComboBox);
            this.Controls.Add(this.feldwerteanzeigenButton);
            this.Controls.Add(this.MitarbeiterentfernenButton);
            this.Controls.Add(this.MitarbeiterhinzufügenButton);
            this.Controls.Add(this.anredeTextBox);
            this.Controls.Add(this.geburtsdatumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personalnummerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mitarbeiterlisteListBox);
            this.Controls.Add(this.mitarbeiterlisteErzeugenButton);
            this.Controls.Add(this.personenlisteListBox);
            this.Controls.Add(this.personenlisteErzeugenButton);
            this.Controls.Add(this.objektErzeugenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button objektErzeugenButton;
        private System.Windows.Forms.Button personenlisteErzeugenButton;
        private System.Windows.Forms.ListBox personenlisteListBox;
        private System.Windows.Forms.ListBox mitarbeiterlisteListBox;
        private System.Windows.Forms.Button mitarbeiterlisteErzeugenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personalnummerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox anredeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox geburtsdatumTextBox;
        private System.Windows.Forms.Button MitarbeiterhinzufügenButton;
        private System.Windows.Forms.Button MitarbeiterentfernenButton;
        private System.Windows.Forms.Button feldwerteanzeigenButton;
        private System.Windows.Forms.ComboBox feldnamenComboBox;
    }
}

