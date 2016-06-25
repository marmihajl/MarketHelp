namespace MarketHelp
{
    partial class Pregled_placa
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
            this.dgvPlace = new System.Windows.Forms.DataGridView();
            this.placeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.OKbutton = new System.Windows.Forms.Button();
            this.placeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odradenosatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odradenoprekovremenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlace
            // 
            this.dgvPlace.AutoGenerateColumns = false;
            this.dgvPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplaceDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.odradenosatiDataGridViewTextBoxColumn,
            this.odradenoprekovremenoDataGridViewTextBoxColumn,
            this.mjesecDataGridViewTextBoxColumn,
            this.iznosplaceDataGridViewTextBoxColumn,
            this.korisniciDataGridViewTextBoxColumn});
            this.dgvPlace.DataSource = this.placeBindingSource2;
            this.dgvPlace.Location = new System.Drawing.Point(12, 12);
            this.dgvPlace.Name = "dgvPlace";
            this.dgvPlace.Size = new System.Drawing.Size(848, 258);
            this.dgvPlace.TabIndex = 0;
            // 
            // placeBindingSource2
            // 
            this.placeBindingSource2.DataSource = typeof(MarketHelp.Place);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(339, 276);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(88, 36);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // placeBindingSource1
            // 
            this.placeBindingSource1.DataSource = typeof(MarketHelp.Place);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MarketHelp.Place);
            // 
            // idplaceDataGridViewTextBoxColumn
            // 
            this.idplaceDataGridViewTextBoxColumn.DataPropertyName = "id_place";
            this.idplaceDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idplaceDataGridViewTextBoxColumn.Name = "idplaceDataGridViewTextBoxColumn";
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            // 
            // odradenosatiDataGridViewTextBoxColumn
            // 
            this.odradenosatiDataGridViewTextBoxColumn.DataPropertyName = "odradeno_sati";
            this.odradenosatiDataGridViewTextBoxColumn.HeaderText = "Odrađeno minuta";
            this.odradenosatiDataGridViewTextBoxColumn.Name = "odradenosatiDataGridViewTextBoxColumn";
            // 
            // odradenoprekovremenoDataGridViewTextBoxColumn
            // 
            this.odradenoprekovremenoDataGridViewTextBoxColumn.DataPropertyName = "odradeno_prekovremeno";
            this.odradenoprekovremenoDataGridViewTextBoxColumn.HeaderText = "Odrađeno prekovremeno";
            this.odradenoprekovremenoDataGridViewTextBoxColumn.Name = "odradenoprekovremenoDataGridViewTextBoxColumn";
            // 
            // mjesecDataGridViewTextBoxColumn
            // 
            this.mjesecDataGridViewTextBoxColumn.DataPropertyName = "mjesec";
            this.mjesecDataGridViewTextBoxColumn.HeaderText = "Mjesec";
            this.mjesecDataGridViewTextBoxColumn.Name = "mjesecDataGridViewTextBoxColumn";
            // 
            // iznosplaceDataGridViewTextBoxColumn
            // 
            this.iznosplaceDataGridViewTextBoxColumn.DataPropertyName = "iznos_place";
            this.iznosplaceDataGridViewTextBoxColumn.HeaderText = "Iznos plaće";
            this.iznosplaceDataGridViewTextBoxColumn.Name = "iznosplaceDataGridViewTextBoxColumn";
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // Pregled_placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 336);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.dgvPlace);
            this.Name = "Pregled_placa";
            this.Text = "Pregled plaća";
            this.Load += new System.EventHandler(this.Pregled_plaća_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlace;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnovrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prekovremenisatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prekovremenisatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznostplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.BindingSource placeBindingSource1;
        private System.Windows.Forms.BindingSource placeBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odradenosatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odradenoprekovremenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
    }
}