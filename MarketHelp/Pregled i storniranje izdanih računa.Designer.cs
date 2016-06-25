namespace MarketHelp
{
    partial class Pregled_i_storniranje_izdanih_racuna
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this._16054_DBDataSet = new MarketHelp._16054_DBDataSet();
            this.naciniplacanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nacini_placanjaTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.Nacini_placanjaTableAdapter();
            this.suradniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suradniciTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.SuradniciTableAdapter();
            this.dokumentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.suradnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naciniplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suradniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naciniplacanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoGenerateColumns = false;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.nacinplacanjaDataGridViewTextBoxColumn,
            this.suradnikDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.korisniciDataGridViewTextBoxColumn,
            this.naciniplacanjaDataGridViewTextBoxColumn,
            this.suradniciDataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn});
            this.dgvRacuni.DataSource = this.dokumentiBindingSource;
            this.dgvRacuni.Location = new System.Drawing.Point(22, 12);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(726, 291);
            this.dgvRacuni.TabIndex = 1;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.dgvRacuni_SelectionChanged);
            this.dgvRacuni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvRacuni_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Storniraj označene račune";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _16054_DBDataSet
            // 
            this._16054_DBDataSet.DataSetName = "_16054_DBDataSet";
            this._16054_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naciniplacanjaBindingSource
            // 
            this.naciniplacanjaBindingSource.DataMember = "Nacini_placanja";
            this.naciniplacanjaBindingSource.DataSource = this._16054_DBDataSet;
            // 
            // nacini_placanjaTableAdapter
            // 
            this.nacini_placanjaTableAdapter.ClearBeforeFill = true;
            // 
            // suradniciBindingSource
            // 
            this.suradniciBindingSource.DataMember = "Suradnici";
            this.suradniciBindingSource.DataSource = this._16054_DBDataSet;
            // 
            // suradniciTableAdapter
            // 
            this.suradniciTableAdapter.ClearBeforeFill = true;
            // 
            // dokumentiBindingSource
            // 
            this.dokumentiBindingSource.DataSource = typeof(MarketHelp.Dokumenti);
            // 
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            this.iddokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacinplacanjaDataGridViewTextBoxColumn
            // 
            this.nacinplacanjaDataGridViewTextBoxColumn.DataPropertyName = "nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.DataSource = this.naciniplacanjaBindingSource;
            this.nacinplacanjaDataGridViewTextBoxColumn.DisplayMember = "naziv_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nacinplacanjaDataGridViewTextBoxColumn.HeaderText = "Način plačanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.Name = "nacinplacanjaDataGridViewTextBoxColumn";
            this.nacinplacanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacinplacanjaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nacinplacanjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nacinplacanjaDataGridViewTextBoxColumn.ValueMember = "id_nacina_placanja";
            // 
            // suradnikDataGridViewTextBoxColumn
            // 
            this.suradnikDataGridViewTextBoxColumn.DataPropertyName = "suradnik";
            this.suradnikDataGridViewTextBoxColumn.DataSource = this.suradniciBindingSource;
            this.suradnikDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.suradnikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.suradnikDataGridViewTextBoxColumn.HeaderText = "Kupac";
            this.suradnikDataGridViewTextBoxColumn.Name = "suradnikDataGridViewTextBoxColumn";
            this.suradnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.suradnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.suradnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.suradnikDataGridViewTextBoxColumn.ValueMember = "oib";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomenta";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // naciniplacanjaDataGridViewTextBoxColumn
            // 
            this.naciniplacanjaDataGridViewTextBoxColumn.DataPropertyName = "Nacini_placanja";
            this.naciniplacanjaDataGridViewTextBoxColumn.HeaderText = "Nacini_placanja";
            this.naciniplacanjaDataGridViewTextBoxColumn.Name = "naciniplacanjaDataGridViewTextBoxColumn";
            this.naciniplacanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.naciniplacanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // suradniciDataGridViewTextBoxColumn
            // 
            this.suradniciDataGridViewTextBoxColumn.DataPropertyName = "Suradnici";
            this.suradniciDataGridViewTextBoxColumn.HeaderText = "Suradnici";
            this.suradniciDataGridViewTextBoxColumn.Name = "suradniciDataGridViewTextBoxColumn";
            this.suradniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.suradniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkedokumentaDataGridViewTextBoxColumn
            // 
            this.stavkedokumentaDataGridViewTextBoxColumn.DataPropertyName = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.HeaderText = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.Name = "stavkedokumentaDataGridViewTextBoxColumn";
            this.stavkedokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkedokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Pregled_i_storniranje_izdanih_racuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "Pregled_i_storniranje_izdanih_racuna";
            this.Text = "Pregled_i_storniranje_izdanih_računa";
            this.Load += new System.EventHandler(this.Pregled_i_storniranje_izdanih_racuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naciniplacanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dokumentiBindingSource;
        private _16054_DBDataSet _16054_DBDataSet;
        private System.Windows.Forms.BindingSource naciniplacanjaBindingSource;
        private _16054_DBDataSetTableAdapters.Nacini_placanjaTableAdapter nacini_placanjaTableAdapter;
        private System.Windows.Forms.BindingSource suradniciBindingSource;
        private _16054_DBDataSetTableAdapters.SuradniciTableAdapter suradniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nacinplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn suradnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naciniplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suradniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkedokumentaDataGridViewTextBoxColumn;
    }
}