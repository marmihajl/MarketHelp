namespace MarketHelp
{
    partial class SlanjeNarudzbe
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.cbArtikl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16054_DBDataSet = new MarketHelp._16054_DBDataSet();
            this.artikliTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dobavljač:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(77, 21);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(126, 21);
            this.cbDobavljac.TabIndex = 9;
            this.cbDobavljac.SelectedValueChanged += new System.EventHandler(this.cbDobavljac_SelectedValueChanged);
            // 
            // cbArtikl
            // 
            this.cbArtikl.FormattingEnabled = true;
            this.cbArtikl.Location = new System.Drawing.Point(77, 64);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(126, 21);
            this.cbArtikl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikl:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(230, 64);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(104, 20);
            this.txtKolicina.TabIndex = 12;
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
            this.dgvStavke.Location = new System.Drawing.Point(15, 112);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.Size = new System.Drawing.Size(665, 208);
            this.dgvStavke.TabIndex = 13;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this._16054_DBDataSet;
            // 
            // _16054_DBDataSet
            // 
            this._16054_DBDataSet.DataSetName = "_16054_DBDataSet";
            this._16054_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Export PDF...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.idartiklaDataGridViewTextBoxColumn.DataSource = this.artikliBindingSource;
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
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
            // stavkedokumentaBindingSource
            // 
            this.stavkedokumentaBindingSource.DataSource = typeof(MarketHelp.Stavke_dokumenta);
            // 
            // SlanjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.cbArtikl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SlanjeNarudzbe";
            this.Text = "Slanje narudzbe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlanjeNarudzbe_FormClosing);
            this.Load += new System.EventHandler(this.SlanjeNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkedokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.ComboBox cbArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.BindingSource stavkedokumentaBindingSource;
        private _16054_DBDataSet _16054_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private _16054_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}