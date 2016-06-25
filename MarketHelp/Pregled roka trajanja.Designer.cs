namespace MarketHelp
{
    partial class Pregled_roka_trajanja
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
            this.dgbRok = new System.Windows.Forms.DataGridView();
            this.PotvrdiButton = new System.Windows.Forms.Button();
            this.OdustaniButton = new System.Windows.Forms.Button();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roktrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljaciartikalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkedokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukloni = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbRok
            // 
            this.dgbRok.AutoGenerateColumns = false;
            this.dgbRok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbRok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idartiklaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.roktrajanjaDataGridViewTextBoxColumn,
            this.minkolicinaDataGridViewTextBoxColumn,
            this.maxkolicinaDataGridViewTextBoxColumn,
            this.dobavljaciartikalaDataGridViewTextBoxColumn,
            this.stavkedokumentaDataGridViewTextBoxColumn,
            this.ukloni});
            this.dgbRok.DataSource = this.artikliBindingSource;
            this.dgbRok.Location = new System.Drawing.Point(12, 12);
            this.dgbRok.Name = "dgbRok";
            this.dgbRok.Size = new System.Drawing.Size(785, 208);
            this.dgbRok.TabIndex = 0;
            // 
            // PotvrdiButton
            // 
            this.PotvrdiButton.Location = new System.Drawing.Point(60, 226);
            this.PotvrdiButton.Name = "PotvrdiButton";
            this.PotvrdiButton.Size = new System.Drawing.Size(113, 44);
            this.PotvrdiButton.TabIndex = 1;
            this.PotvrdiButton.Text = "Potvrdi";
            this.PotvrdiButton.UseVisualStyleBackColor = true;
            this.PotvrdiButton.Click += new System.EventHandler(this.PotvrdiButton_Click);
            // 
            // OdustaniButton
            // 
            this.OdustaniButton.Location = new System.Drawing.Point(233, 226);
            this.OdustaniButton.Name = "OdustaniButton";
            this.OdustaniButton.Size = new System.Drawing.Size(110, 43);
            this.OdustaniButton.TabIndex = 2;
            this.OdustaniButton.Text = "Odustani";
            this.OdustaniButton.UseVisualStyleBackColor = true;
            this.OdustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(MarketHelp.Artikli);
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
            this.cijenaDataGridViewTextBoxColumn.Visible = false;
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
            this.minkolicinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // maxkolicinaDataGridViewTextBoxColumn
            // 
            this.maxkolicinaDataGridViewTextBoxColumn.DataPropertyName = "max_kolicina";
            this.maxkolicinaDataGridViewTextBoxColumn.HeaderText = "Max. količina";
            this.maxkolicinaDataGridViewTextBoxColumn.Name = "maxkolicinaDataGridViewTextBoxColumn";
            this.maxkolicinaDataGridViewTextBoxColumn.Visible = false;
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
            // ukloni
            // 
            this.ukloni.HeaderText = "Ukloni";
            this.ukloni.Name = "ukloni";
            this.ukloni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Pregled_roka_trajanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 282);
            this.Controls.Add(this.OdustaniButton);
            this.Controls.Add(this.PotvrdiButton);
            this.Controls.Add(this.dgbRok);
            this.Name = "Pregled_roka_trajanja";
            this.Text = "Pregled_roka_trajanja";
            this.Load += new System.EventHandler(this.Pregled_roka_trajanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbRok;
        private System.Windows.Forms.Button PotvrdiButton;
        private System.Windows.Forms.Button OdustaniButton;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roktrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljaciartikalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkedokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ukloni;
    }
}