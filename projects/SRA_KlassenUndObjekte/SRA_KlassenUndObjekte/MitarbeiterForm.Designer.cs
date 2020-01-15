namespace SRA_KlassenUndObjekte
{
    partial class MitarbeiterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anredeComboBox = new System.Windows.Forms.ComboBox();
            this.geburtsdatumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personalnummerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anredeComboBox
            // 
            this.anredeComboBox.FormattingEnabled = true;
            this.anredeComboBox.Location = new System.Drawing.Point(142, 26);
            this.anredeComboBox.Name = "anredeComboBox";
            this.anredeComboBox.Size = new System.Drawing.Size(100, 21);
            this.anredeComboBox.TabIndex = 3;
            // 
            // geburtsdatumTextBox
            // 
            this.geburtsdatumTextBox.Location = new System.Drawing.Point(142, 86);
            this.geburtsdatumTextBox.Name = "geburtsdatumTextBox";
            this.geburtsdatumTextBox.Size = new System.Drawing.Size(100, 20);
            this.geburtsdatumTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Geburtsdatum";
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.Location = new System.Drawing.Point(142, 66);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nachnameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Nachname:";
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(142, 46);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vornameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Anrede:";
            // 
            // personalnummerTextBox
            // 
            this.personalnummerTextBox.Location = new System.Drawing.Point(142, 6);
            this.personalnummerTextBox.Name = "personalnummerTextBox";
            this.personalnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.personalnummerTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Personalnummer:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(90, 112);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbrechenButton.Location = new System.Drawing.Point(171, 112);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(75, 23);
            this.abbrechenButton.TabIndex = 11;
            this.abbrechenButton.Text = "Abbre&chen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            // 
            // MitarbeiterForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.abbrechenButton;
            this.ClientSize = new System.Drawing.Size(258, 154);
            this.Controls.Add(this.abbrechenButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.anredeComboBox);
            this.Controls.Add(this.geburtsdatumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personalnummerTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MitarbeiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MitarbeiterForm";
            this.Load += new System.EventHandler(this.MitarbeiterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox anredeComboBox;
        private System.Windows.Forms.TextBox geburtsdatumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personalnummerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button abbrechenButton;
    }
}