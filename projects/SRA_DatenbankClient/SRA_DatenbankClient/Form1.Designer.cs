namespace SRA_DatenbankClient
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
            this.mitarbeiterlisteListBox = new System.Windows.Forms.ListBox();
            this.mitarbeiterhinzufügenButton = new System.Windows.Forms.Button();
            this.mitarbeiterentfernenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mitarbeiterlisteListBox
            // 
            this.mitarbeiterlisteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mitarbeiterlisteListBox.FormattingEnabled = true;
            this.mitarbeiterlisteListBox.Location = new System.Drawing.Point(12, 12);
            this.mitarbeiterlisteListBox.Name = "mitarbeiterlisteListBox";
            this.mitarbeiterlisteListBox.Size = new System.Drawing.Size(416, 186);
            this.mitarbeiterlisteListBox.TabIndex = 0;
            this.mitarbeiterlisteListBox.DoubleClick += new System.EventHandler(this.mitarbeiterlisteListBox_DoubleClick);
            // 
            // mitarbeiterhinzufügenButton
            // 
            this.mitarbeiterhinzufügenButton.Location = new System.Drawing.Point(12, 204);
            this.mitarbeiterhinzufügenButton.Name = "mitarbeiterhinzufügenButton";
            this.mitarbeiterhinzufügenButton.Size = new System.Drawing.Size(147, 134);
            this.mitarbeiterhinzufügenButton.TabIndex = 1;
            this.mitarbeiterhinzufügenButton.Text = "&Mitarbeiter hinzufügen";
            this.mitarbeiterhinzufügenButton.UseVisualStyleBackColor = true;
            this.mitarbeiterhinzufügenButton.Click += new System.EventHandler(this.mitarbeiterhinzufügenButton_Click);
            // 
            // mitarbeiterentfernenButton
            // 
            this.mitarbeiterentfernenButton.Location = new System.Drawing.Point(165, 204);
            this.mitarbeiterentfernenButton.Name = "mitarbeiterentfernenButton";
            this.mitarbeiterentfernenButton.Size = new System.Drawing.Size(143, 134);
            this.mitarbeiterentfernenButton.TabIndex = 2;
            this.mitarbeiterentfernenButton.Text = "Mitarbeiter &entfernen";
            this.mitarbeiterentfernenButton.UseVisualStyleBackColor = true;
            this.mitarbeiterentfernenButton.Click += new System.EventHandler(this.mitarbeiterentfernenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 426);
            this.Controls.Add(this.mitarbeiterentfernenButton);
            this.Controls.Add(this.mitarbeiterhinzufügenButton);
            this.Controls.Add(this.mitarbeiterlisteListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mitarbeiterlisteListBox;
        private System.Windows.Forms.Button mitarbeiterhinzufügenButton;
        private System.Windows.Forms.Button mitarbeiterentfernenButton;
    }
}

