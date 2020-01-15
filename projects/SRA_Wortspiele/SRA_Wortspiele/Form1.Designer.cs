namespace SRA_Wortspiele
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
            this.wörterListBox = new System.Windows.Forms.ListBox();
            this.enthaltenezeichenfolgeLabel = new System.Windows.Forms.Label();
            this.enthaltenezeichenfolgeTextBox = new System.Windows.Forms.TextBox();
            this.mindestlängeLabel = new System.Windows.Forms.Label();
            this.mindestlängeTextBox = new System.Windows.Forms.NumericUpDown();
            this.maximallängeLabel = new System.Windows.Forms.Label();
            this.maximallängeTextBox = new System.Windows.Forms.NumericUpDown();
            this.großKleinschreibungCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mindestlängeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximallängeTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wörterListBox
            // 
            this.wörterListBox.FormattingEnabled = true;
            this.wörterListBox.Location = new System.Drawing.Point(12, 12);
            this.wörterListBox.Name = "wörterListBox";
            this.wörterListBox.Size = new System.Drawing.Size(245, 511);
            this.wörterListBox.TabIndex = 0;
            // 
            // enthaltenezeichenfolgeLabel
            // 
            this.enthaltenezeichenfolgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enthaltenezeichenfolgeLabel.AutoSize = true;
            this.enthaltenezeichenfolgeLabel.Location = new System.Drawing.Point(290, 15);
            this.enthaltenezeichenfolgeLabel.Name = "enthaltenezeichenfolgeLabel";
            this.enthaltenezeichenfolgeLabel.Size = new System.Drawing.Size(123, 13);
            this.enthaltenezeichenfolgeLabel.TabIndex = 1;
            this.enthaltenezeichenfolgeLabel.Text = "&Enthaltene Zeichenfolge";
            // 
            // enthaltenezeichenfolgeTextBox
            // 
            this.enthaltenezeichenfolgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enthaltenezeichenfolgeTextBox.Location = new System.Drawing.Point(418, 12);
            this.enthaltenezeichenfolgeTextBox.Name = "enthaltenezeichenfolgeTextBox";
            this.enthaltenezeichenfolgeTextBox.Size = new System.Drawing.Size(120, 20);
            this.enthaltenezeichenfolgeTextBox.TabIndex = 2;
            // 
            // mindestlängeLabel
            // 
            this.mindestlängeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mindestlängeLabel.AutoSize = true;
            this.mindestlängeLabel.Location = new System.Drawing.Point(290, 47);
            this.mindestlängeLabel.Name = "mindestlängeLabel";
            this.mindestlängeLabel.Size = new System.Drawing.Size(70, 13);
            this.mindestlängeLabel.TabIndex = 3;
            this.mindestlängeLabel.Text = "Mindestlänge";
            // 
            // mindestlängeTextBox
            // 
            this.mindestlängeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mindestlängeTextBox.Location = new System.Drawing.Point(418, 45);
            this.mindestlängeTextBox.Name = "mindestlängeTextBox";
            this.mindestlängeTextBox.Size = new System.Drawing.Size(120, 20);
            this.mindestlängeTextBox.TabIndex = 4;
            // 
            // maximallängeLabel
            // 
            this.maximallängeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximallängeLabel.AutoSize = true;
            this.maximallängeLabel.Location = new System.Drawing.Point(290, 80);
            this.maximallängeLabel.Name = "maximallängeLabel";
            this.maximallängeLabel.Size = new System.Drawing.Size(71, 13);
            this.maximallängeLabel.TabIndex = 5;
            this.maximallängeLabel.Text = "Maximallänge";
            // 
            // maximallängeTextBox
            // 
            this.maximallängeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximallängeTextBox.Location = new System.Drawing.Point(418, 78);
            this.maximallängeTextBox.Name = "maximallängeTextBox";
            this.maximallängeTextBox.Size = new System.Drawing.Size(120, 20);
            this.maximallängeTextBox.TabIndex = 6;
            // 
            // großKleinschreibungCheckBox
            // 
            this.großKleinschreibungCheckBox.Location = new System.Drawing.Point(293, 104);
            this.großKleinschreibungCheckBox.Name = "großKleinschreibungCheckBox";
            this.großKleinschreibungCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.großKleinschreibungCheckBox.Size = new System.Drawing.Size(139, 37);
            this.großKleinschreibungCheckBox.TabIndex = 7;
            this.großKleinschreibungCheckBox.Text = "Groß- / Kleinschreibung beachten";
            this.großKleinschreibungCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 530);
            this.Controls.Add(this.großKleinschreibungCheckBox);
            this.Controls.Add(this.maximallängeTextBox);
            this.Controls.Add(this.maximallängeLabel);
            this.Controls.Add(this.mindestlängeTextBox);
            this.Controls.Add(this.mindestlängeLabel);
            this.Controls.Add(this.enthaltenezeichenfolgeTextBox);
            this.Controls.Add(this.enthaltenezeichenfolgeLabel);
            this.Controls.Add(this.wörterListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mindestlängeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximallängeTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wörterListBox;
        private System.Windows.Forms.Label enthaltenezeichenfolgeLabel;
        private System.Windows.Forms.TextBox enthaltenezeichenfolgeTextBox;
        private System.Windows.Forms.Label mindestlängeLabel;
        private System.Windows.Forms.NumericUpDown mindestlängeTextBox;
        private System.Windows.Forms.Label maximallängeLabel;
        private System.Windows.Forms.NumericUpDown maximallängeTextBox;
        private System.Windows.Forms.CheckBox großKleinschreibungCheckBox;
    }
}

