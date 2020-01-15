namespace SRA_EtwasMitThreads
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
            this.startenButton = new System.Windows.Forms.Button();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.datenListBox = new System.Windows.Forms.ListBox();
            this.fortschrittProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startenButton
            // 
            this.startenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startenButton.Location = new System.Drawing.Point(12, 12);
            this.startenButton.Name = "startenButton";
            this.startenButton.Size = new System.Drawing.Size(346, 23);
            this.startenButton.TabIndex = 0;
            this.startenButton.Text = "&Starten";
            this.startenButton.UseVisualStyleBackColor = true;
            this.startenButton.Click += new System.EventHandler(this.startenButton_Click);
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abbrechenButton.Location = new System.Drawing.Point(12, 41);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(346, 23);
            this.abbrechenButton.TabIndex = 1;
            this.abbrechenButton.Text = "&Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            this.abbrechenButton.Click += new System.EventHandler(this.abbrechenButton_Click);
            // 
            // datenListBox
            // 
            this.datenListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datenListBox.FormattingEnabled = true;
            this.datenListBox.Location = new System.Drawing.Point(12, 70);
            this.datenListBox.Name = "datenListBox";
            this.datenListBox.Size = new System.Drawing.Size(346, 394);
            this.datenListBox.TabIndex = 2;
            // 
            // fortschrittProgressBar
            // 
            this.fortschrittProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fortschrittProgressBar.Location = new System.Drawing.Point(12, 477);
            this.fortschrittProgressBar.Name = "fortschrittProgressBar";
            this.fortschrittProgressBar.Size = new System.Drawing.Size(346, 23);
            this.fortschrittProgressBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 512);
            this.Controls.Add(this.fortschrittProgressBar);
            this.Controls.Add(this.datenListBox);
            this.Controls.Add(this.abbrechenButton);
            this.Controls.Add(this.startenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startenButton;
        private System.Windows.Forms.Button abbrechenButton;
        private System.Windows.Forms.ListBox datenListBox;
        private System.Windows.Forms.ProgressBar fortschrittProgressBar;
    }
}

