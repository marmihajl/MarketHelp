namespace MarketHelp
{
    partial class Izdavanje_racuna
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPregledIStorniranje = new System.Windows.Forms.Button();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cbArtikl = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.cbPlacanje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._16054_DBDataSet = new MarketHelp._16054_DBDataSet();
            this.artikliBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.suradniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkedokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Popust";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ukupna cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj kupca";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(90, 379);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(67, 20);
            this.txtPopust.TabIndex = 9;
            this.txtPopust.TextChanged += new System.EventHandler(this.txtPopust_TextChanged);
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(90, 413);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(220, 20);
            this.txtUkupno.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Izdaj račun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregledIStorniranje
            // 
            this.btnPregledIStorniranje.Location = new System.Drawing.Point(439, 448);
            this.btnPregledIStorniranje.Name = "btnPregledIStorniranje";
            this.btnPregledIStorniranje.Size = new System.Drawing.Size(162, 23);
            this.btnPregledIStorniranje.TabIndex = 15;
            this.btnPregledIStorniranje.Text = "Pregled i storniranje računa";
            this.btnPregledIStorniranje.UseVisualStyleBackColor = true;
            this.btnPregledIStorniranje.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbKupac
            // 
            this.cbKupac.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suradniciBindingSource, "oib", true));
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(76, 6);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(142, 21);
            this.cbKupac.TabIndex = 16;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.AutoGenerateColumns = false;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.idartiklaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.dokumentiDataGridViewTextBoxColumn});
            this.dgvStavke.DataSource = this.stavkedokumentaBindingSource;
            this.dgvStavke.Location = new System.Drawing.Point(15, 84);
            this.dgvStavke.MultiSelect = false;
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(343, 279);
            this.dgvStavke.TabIndex = 17;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(163, 50);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(55, 20);
            this.txtKolicina.TabIndex = 19;
            // 
            // cbArtikl
            // 
            this.cbArtikl.FormattingEnabled = true;
            this.cbArtikl.Location = new System.Drawing.Point(15, 48);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(142, 21);
            this.cbArtikl.TabIndex = 20;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(224, 50);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(26, 23);
            this.dodaj.TabIndex = 21;
            this.dodaj.Text = "+";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // cbPlacanje
            // 
            this.cbPlacanje.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suradniciBindingSource, "oib", true));
            this.cbPlacanje.FormattingEnabled = true;
            this.cbPlacanje.Location = new System.Drawing.Point(336, 6);
            this.cbPlacanje.Name = "cbPlacanje";
            this.cbPlacanje.Size = new System.Drawing.Size(142, 21);
            this.cbPlacanje.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Način plačanja";
            // 
            // _16054_DBDataSet
            // 
            this._16054_DBDataSet.DataSetName = "_16054_DBDataSet";
            this._16054_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource2
            // 
            this.artikliBindingSource2.DataMember = "Artikli";
            this.artikliBindingSource2.DataSource = this._16054_DBDataSet;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // suradniciBindingSource
            // 
            this.suradniciBindingSource.DataSource = typeof(MarketHelp.Suradnici);
            // 
            // stavkedokumentaBindingSource
            // 
            this.stavkedokumentaBindingSource.DataSource = typeof(MarketHelp.Stavke_dokumenta);
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataSource = typeof(MarketHelp.Artikli);
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(MarketHelp.Artikli);
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.DataSource = this.artikliBindingSource2;
            this.idartiklaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idartiklaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "Artikl";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            this.idartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idartiklaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idartiklaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idartiklaDataGridViewTextBoxColumn.ValueMember = "id_artikla";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "Artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "Artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // dokumentiDataGridViewTextBoxColumn
            // 
            this.dokumentiDataGridViewTextBoxColumn.DataPropertyName = "Dokumenti";
            this.dokumentiDataGridViewTextBoxColumn.HeaderText = "Dokumenti";
            this.dokumentiDataGridViewTextBoxColumn.Name = "dokumentiDataGridViewTextBoxColumn";
            this.dokumentiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentiDataGridViewTextBoxColumn.Visible = false;
            // 
            // Izdavanje_racuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 483);
            this.Controls.Add(this.cbPlacanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.cbArtikl);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.btnPregledIStorniranje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Izdavanje_racuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje_racuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Izdavanje_racuna_FormClosing);
            this.Load += new System.EventHandler(this.Izdavanje_racuna_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPregledIStorniranje;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.BindingSource stavkedokumentaBindingSource;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cbArtikl;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.BindingSource suradniciBindingSource;
        private System.Windows.Forms.ComboBox cbPlacanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private _16054_DBDataSet _16054_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource2;
        private _16054_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentiDataGridViewTextBoxColumn;
    }
}