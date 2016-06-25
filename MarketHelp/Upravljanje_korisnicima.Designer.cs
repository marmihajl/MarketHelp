namespace MarketHelp
{
    partial class Upravljanje_korisnicima
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._16054_DBDataSet = new MarketHelp._16054_DBDataSet();
            this.ulogekorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uloge_korisnikaTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.Uloge_korisnikaTableAdapter();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idulogeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.imeprezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogekorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogekorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.idulogeDataGridViewTextBoxColumn,
            this.imeprezimeDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.dokumentiDataGridViewTextBoxColumn,
            this.ulogekorisnikaDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisniciBindingSource;
            this.dgvKorisnici.Location = new System.Drawing.Point(18, 101);
            this.dgvKorisnici.MultiSelect = false;
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(551, 189);
            this.dgvKorisnici.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis svih korisnika :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Obriši označene korisnike";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj novog korisnika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Uredi označenog korisnika";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // _16054_DBDataSet
            // 
            this._16054_DBDataSet.DataSetName = "_16054_DBDataSet";
            this._16054_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogekorisnikaBindingSource
            // 
            this.ulogekorisnikaBindingSource.DataMember = "Uloge_korisnika";
            this.ulogekorisnikaBindingSource.DataSource = this._16054_DBDataSet;
            // 
            // uloge_korisnikaTableAdapter
            // 
            this.uloge_korisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idulogeDataGridViewTextBoxColumn
            // 
            this.idulogeDataGridViewTextBoxColumn.DataPropertyName = "id_uloge";
            this.idulogeDataGridViewTextBoxColumn.DataSource = this.ulogekorisnikaBindingSource;
            this.idulogeDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idulogeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idulogeDataGridViewTextBoxColumn.HeaderText = "Tip korisnika";
            this.idulogeDataGridViewTextBoxColumn.Name = "idulogeDataGridViewTextBoxColumn";
            this.idulogeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idulogeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idulogeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idulogeDataGridViewTextBoxColumn.ValueMember = "id_uloge";
            // 
            // imeprezimeDataGridViewTextBoxColumn
            // 
            this.imeprezimeDataGridViewTextBoxColumn.DataPropertyName = "ime_prezime";
            this.imeprezimeDataGridViewTextBoxColumn.HeaderText = "Ime i prezime";
            this.imeprezimeDataGridViewTextBoxColumn.Name = "imeprezimeDataGridViewTextBoxColumn";
            this.imeprezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokumentiDataGridViewTextBoxColumn
            // 
            this.dokumentiDataGridViewTextBoxColumn.DataPropertyName = "Dokumenti";
            this.dokumentiDataGridViewTextBoxColumn.HeaderText = "Dokumenti";
            this.dokumentiDataGridViewTextBoxColumn.Name = "dokumentiDataGridViewTextBoxColumn";
            this.dokumentiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentiDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulogekorisnikaDataGridViewTextBoxColumn
            // 
            this.ulogekorisnikaDataGridViewTextBoxColumn.DataPropertyName = "Uloge_korisnika";
            this.ulogekorisnikaDataGridViewTextBoxColumn.HeaderText = "Uloge_korisnika";
            this.ulogekorisnikaDataGridViewTextBoxColumn.Name = "ulogekorisnikaDataGridViewTextBoxColumn";
            this.ulogekorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ulogekorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataSource = typeof(MarketHelp.Korisnici);
            // 
            // Upravljanje_korisnicima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "Upravljanje_korisnicima";
            this.Text = "Upravljanje_korisnicima";
            this.Load += new System.EventHandler(this.Upravljanje_korisnicima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogekorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private System.Windows.Forms.Button button3;
        private _16054_DBDataSet _16054_DBDataSet;
        private System.Windows.Forms.BindingSource ulogekorisnikaBindingSource;
        private _16054_DBDataSetTableAdapters.Uloge_korisnikaTableAdapter uloge_korisnikaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idulogeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeprezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogekorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
    }
}