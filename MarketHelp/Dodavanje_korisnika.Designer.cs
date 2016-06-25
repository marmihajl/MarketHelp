namespace MarketHelp
{
    partial class Dodavanje_korisnika
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.ulogekorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrekovremeno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogekorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime i prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tel. broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Korisničko ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lozinka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Uloga";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(115, 175);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(115, 210);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(157, 20);
            this.txtKontakt.TabIndex = 9;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(115, 82);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(157, 20);
            this.txtKorisnickoIme.TabIndex = 10;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(115, 111);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(157, 20);
            this.txtLozinka.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Povratak";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbUloga
            // 
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(115, 138);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(157, 21);
            this.cbUloga.TabIndex = 15;
            // 
            // ulogekorisnikaBindingSource
            // 
            this.ulogekorisnikaBindingSource.DataSource = typeof(MarketHelp.Uloge_korisnika);
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(MarketHelp.Korisnici);
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(115, 242);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(157, 20);
            this.txtSatnica.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Satnica";
            // 
            // txtPrekovremeno
            // 
            this.txtPrekovremeno.Location = new System.Drawing.Point(115, 271);
            this.txtPrekovremeno.Name = "txtPrekovremeno";
            this.txtPrekovremeno.Size = new System.Drawing.Size(157, 20);
            this.txtPrekovremeno.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Prekovremeni";
            // 
            // Dodavanje_korisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 344);
            this.Controls.Add(this.txtPrekovremeno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dodavanje_korisnika";
            this.Text = "Dodavanje_korisnika";
            this.Load += new System.EventHandler(this.Dodavanje_korisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogekorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.BindingSource ulogekorisnikaBindingSource;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrekovremeno;
        private System.Windows.Forms.Label label7;
    }
}