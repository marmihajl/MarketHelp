namespace MarketHelp
{
    partial class Zalihe
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
            this.dgvZalihe = new System.Windows.Forms.DataGridView();
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roktrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciartikalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZalihe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZalihe
            // 
            this.dgvZalihe.AllowUserToAddRows = false;
            this.dgvZalihe.AllowUserToDeleteRows = false;
            this.dgvZalihe.AutoGenerateColumns = false;
            this.dgvZalihe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZalihe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.roktrajanjaDataGridViewTextBoxColumn,
            this.minkolicinaDataGridViewTextBoxColumn,
            this.maxkolicinaDataGridViewTextBoxColumn,
            this.dobavljaciartikalaDataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn});
            this.dgvZalihe.DataSource = this.artikliBindingSource;
            this.dgvZalihe.Location = new System.Drawing.Point(13, 13);
            this.dgvZalihe.Name = "dgvZalihe";
            this.dgvZalihe.ReadOnly = true;
            this.dgvZalihe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZalihe.Size = new System.Drawing.Size(746, 307);
            this.dgvZalihe.TabIndex = 0;
            // 
            // idartiklaDataGridViewTextBoxColumn
            // 
            this.idartiklaDataGridViewTextBoxColumn.DataPropertyName = "id_artikla";
            this.idartiklaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idartiklaDataGridViewTextBoxColumn.Name = "idartiklaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // roktrajanjaDataGridViewTextBoxColumn
            // 
            this.roktrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rok_trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.Name = "roktrajanjaDataGridViewTextBoxColumn";
            // 
            // minkolicinaDataGridViewTextBoxColumn
            // 
            this.minkolicinaDataGridViewTextBoxColumn.DataPropertyName = "min_kolicina";
            this.minkolicinaDataGridViewTextBoxColumn.HeaderText = "Min. količina";
            this.minkolicinaDataGridViewTextBoxColumn.Name = "minkolicinaDataGridViewTextBoxColumn";
            // 
            // maxkolicinaDataGridViewTextBoxColumn
            // 
            this.maxkolicinaDataGridViewTextBoxColumn.DataPropertyName = "max_kolicina";
            this.maxkolicinaDataGridViewTextBoxColumn.HeaderText = "Max. količina";
            this.maxkolicinaDataGridViewTextBoxColumn.Name = "maxkolicinaDataGridViewTextBoxColumn";
            // 
            // dobavljaciartikalaDataGridViewTextBoxColumn
            // 
            this.dobavljaciartikalaDataGridViewTextBoxColumn.DataPropertyName = "Dobavljaci_artikala";
            this.dobavljaciartikalaDataGridViewTextBoxColumn.HeaderText = "Dobavljaci_artikala";
            this.dobavljaciartikalaDataGridViewTextBoxColumn.Name = "dobavljaciartikalaDataGridViewTextBoxColumn";
            this.dobavljaciartikalaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkedokumentaDataGridViewTextBoxColumn
            // 
            this.stavkedokumentaDataGridViewTextBoxColumn.DataPropertyName = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.HeaderText = "Stavke_dokumenta";
            this.stavkedokumentaDataGridViewTextBoxColumn.Name = "stavkedokumentaDataGridViewTextBoxColumn";
            this.stavkedokumentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(MarketHelp.Artikli);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "U redu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zalihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZalihe);
            this.Name = "Zalihe";
            this.Text = "Zalihe";
            this.Load += new System.EventHandler(this.Zalihe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZalihe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZalihe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roktrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciartikalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkedokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artikliBindingSource;
    }
}