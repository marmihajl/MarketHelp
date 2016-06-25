namespace MarketHelp
{
    partial class NoviSuradnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.odustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Napomena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naziv:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(98, 8);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(158, 20);
            this.txtOIB.TabIndex = 5;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(98, 113);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(274, 175);
            this.txtNapomena.TabIndex = 6;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(98, 88);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(158, 20);
            this.txtKontakt.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(98, 64);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(158, 20);
            this.txtAdresa.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(98, 35);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(158, 20);
            this.txtNaziv.TabIndex = 9;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(146, 309);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 10;
            this.dodaj.Text = "Dodaj dobavljača";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // odustani
            // 
            this.odustani.Location = new System.Drawing.Point(278, 309);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(75, 23);
            this.odustani.TabIndex = 11;
            this.odustani.Text = "Odustani";
            this.odustani.UseVisualStyleBackColor = true;
            this.odustani.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoviSuradnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoviSuradnik";
            this.Text = "Novi suradnik";
            this.Load += new System.EventHandler(this.NoviSuradnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button odustani;
    }
}