namespace MarketHelp
{
    partial class UpravljanjeNarudzbama
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.cmsNarudzbe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._16054_DBDataSet = new MarketHelp._16054_DBDataSet();
            this.naciniplacanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nacini_placanjaTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.Nacini_placanjaTableAdapter();
            this.suradniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suradniciTableAdapter = new MarketHelp._16054_DBDataSetTableAdapters.SuradniciTableAdapter();
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
            this.zaprimljeno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.cmsNarudzbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naciniplacanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AutoGenerateColumns = false;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddokumentaDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.nacinplacanjaDataGridViewTextBoxColumn,
            this.suradnikDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.korisniciDataGridViewTextBoxColumn,
            this.naciniplacanjaDataGridViewTextBoxColumn,
            this.suradniciDataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn,
            this.zaprimljeno});
            this.dgvNarudzbe.ContextMenuStrip = this.cmsNarudzbe;
            this.dgvNarudzbe.DataSource = this.dokumentiBindingSource;
            this.dgvNarudzbe.Location = new System.Drawing.Point(176, 13);
            this.dgvNarudzbe.MultiSelect = false;
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(768, 302);
            this.dgvNarudzbe.TabIndex = 0;
            // 
            // cmsNarudzbe
            // 
            this.cmsNarudzbe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsNarudzbe.Name = "cmsNarudzbe";
            this.cmsNarudzbe.Size = new System.Drawing.Size(169, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Detalji narudžbe...";
            this.toolStripMenuItem1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem1_MouseUp);
            // 
            // dokumentiBindingSource
            // 
            this.dokumentiBindingSource.DataSource = typeof(MarketHelp.Dokumenti);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Slanje narudžbe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zalihe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Unos parametara zaliha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Potvrda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // iddokumentaDataGridViewTextBoxColumn
            // 
            this.iddokumentaDataGridViewTextBoxColumn.DataPropertyName = "id_dokumenta";
            this.iddokumentaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iddokumentaDataGridViewTextBoxColumn.Name = "iddokumentaDataGridViewTextBoxColumn";
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Kreator";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            // 
            // nacinplacanjaDataGridViewTextBoxColumn
            // 
            this.nacinplacanjaDataGridViewTextBoxColumn.DataPropertyName = "nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.DataSource = this.naciniplacanjaBindingSource;
            this.nacinplacanjaDataGridViewTextBoxColumn.DisplayMember = "naziv_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nacinplacanjaDataGridViewTextBoxColumn.HeaderText = "Način plačanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.Name = "nacinplacanjaDataGridViewTextBoxColumn";
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
            this.suradnikDataGridViewTextBoxColumn.HeaderText = "Suradnik";
            this.suradnikDataGridViewTextBoxColumn.Name = "suradnikDataGridViewTextBoxColumn";
            this.suradnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.suradnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.suradnikDataGridViewTextBoxColumn.ValueMember = "oib";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // naciniplacanjaDataGridViewTextBoxColumn
            // 
            this.naciniplacanjaDataGridViewTextBoxColumn.DataPropertyName = "Nacini_placanja";
            this.naciniplacanjaDataGridViewTextBoxColumn.HeaderText = "Nacini_placanja";
            this.naciniplacanjaDataGridViewTextBoxColumn.Name = "naciniplacanjaDataGridViewTextBoxColumn";
            this.naciniplacanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // suradniciDataGridViewTextBoxColumn
            // 
            this.suradniciDataGridViewTextBoxColumn.DataPropertyName = "Suradnici";
            this.suradniciDataGridViewTextBoxColumn.HeaderText = "Suradnici";
            this.suradniciDataGridViewTextBoxColumn.Name = "suradniciDataGridViewTextBoxColumn";
            this.suradniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkedokumentaDataGridViewTextBoxColumn
            // 
            this.stavkedokumentaDataGridViewTextBoxColumn.DataPropertyName = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.HeaderText = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.Name = "stavkedokumentaDataGridViewTextBoxColumn";
            this.stavkedokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaprimljeno
            // 
            this.zaprimljeno.HeaderText = "Zaprimljeno";
            this.zaprimljeno.Name = "zaprimljeno";
            // 
            // UpravljanjeNarudzbama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "UpravljanjeNarudzbama";
            this.Text = "Upravljanje narudzbama";
            this.Load += new System.EventHandler(this.UpravljanjeNarudzbama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.cmsNarudzbe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dokumentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16054_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naciniplacanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suradniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource dokumentiBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmsNarudzbe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn zaprimljeno;
    }
}