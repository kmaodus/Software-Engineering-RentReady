namespace LoginForma
{
    partial class PregledPremaOdabranomPartneruForma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zgradaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zgradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_18082 = new LoginForma.DB_18082();
            this.tvrtkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moguciPosloviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mogucPosaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetakRadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajRadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorenPosaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mogucPosaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mogucPosaoTableAdapter = new LoginForma.DB_18082TableAdapters.MogucPosaoTableAdapter();
            this.ugovorenPosaoTableAdapter = new LoginForma.DB_18082TableAdapters.UgovorenPosaoTableAdapter();
            this.zgradaTableAdapter = new LoginForma.DB_18082TableAdapters.ZgradaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorenPosaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zgradaIDDataGridViewTextBoxColumn,
            this.tvrtkaIDDataGridViewTextBoxColumn,
            this.moguciPosloviIDDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.pocetakRadaDataGridViewTextBoxColumn,
            this.krajRadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ugovorenPosaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // zgradaIDDataGridViewTextBoxColumn
            // 
            this.zgradaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zgradaIDDataGridViewTextBoxColumn.DataPropertyName = "ZgradaID";
            this.zgradaIDDataGridViewTextBoxColumn.DataSource = this.zgradaBindingSource;
            this.zgradaIDDataGridViewTextBoxColumn.DisplayMember = "Lokacija";
            this.zgradaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zgradaIDDataGridViewTextBoxColumn.HeaderText = "Zgrada";
            this.zgradaIDDataGridViewTextBoxColumn.Name = "zgradaIDDataGridViewTextBoxColumn";
            this.zgradaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zgradaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zgradaIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // zgradaBindingSource
            // 
            this.zgradaBindingSource.DataMember = "Zgrada";
            this.zgradaBindingSource.DataSource = this.dB_18082;
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tvrtkaIDDataGridViewTextBoxColumn
            // 
            this.tvrtkaIDDataGridViewTextBoxColumn.DataPropertyName = "TvrtkaID";
            this.tvrtkaIDDataGridViewTextBoxColumn.HeaderText = "TvrtkaID";
            this.tvrtkaIDDataGridViewTextBoxColumn.Name = "tvrtkaIDDataGridViewTextBoxColumn";
            this.tvrtkaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // moguciPosloviIDDataGridViewTextBoxColumn
            // 
            this.moguciPosloviIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moguciPosloviIDDataGridViewTextBoxColumn.DataPropertyName = "MoguciPosloviID";
            this.moguciPosloviIDDataGridViewTextBoxColumn.DataSource = this.mogucPosaoBindingSource1;
            this.moguciPosloviIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.moguciPosloviIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.moguciPosloviIDDataGridViewTextBoxColumn.HeaderText = "Posao";
            this.moguciPosloviIDDataGridViewTextBoxColumn.Name = "moguciPosloviIDDataGridViewTextBoxColumn";
            this.moguciPosloviIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.moguciPosloviIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.moguciPosloviIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // mogucPosaoBindingSource1
            // 
            this.mogucPosaoBindingSource1.DataMember = "MogucPosao";
            this.mogucPosaoBindingSource1.DataSource = this.dB_18082;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // pocetakRadaDataGridViewTextBoxColumn
            // 
            this.pocetakRadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pocetakRadaDataGridViewTextBoxColumn.DataPropertyName = "PocetakRada";
            this.pocetakRadaDataGridViewTextBoxColumn.HeaderText = "Pocetak rada";
            this.pocetakRadaDataGridViewTextBoxColumn.Name = "pocetakRadaDataGridViewTextBoxColumn";
            // 
            // krajRadaDataGridViewTextBoxColumn
            // 
            this.krajRadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.krajRadaDataGridViewTextBoxColumn.DataPropertyName = "KrajRada";
            this.krajRadaDataGridViewTextBoxColumn.HeaderText = "Kraj rada";
            this.krajRadaDataGridViewTextBoxColumn.Name = "krajRadaDataGridViewTextBoxColumn";
            // 
            // ugovorenPosaoBindingSource
            // 
            this.ugovorenPosaoBindingSource.DataMember = "UgovorenPosao";
            this.ugovorenPosaoBindingSource.DataSource = this.dB_18082;
            // 
            // mogucPosaoBindingSource
            // 
            this.mogucPosaoBindingSource.DataMember = "MogucPosao";
            this.mogucPosaoBindingSource.DataSource = this.dB_18082;
            // 
            // mogucPosaoTableAdapter
            // 
            this.mogucPosaoTableAdapter.ClearBeforeFill = true;
            // 
            // ugovorenPosaoTableAdapter
            // 
            this.ugovorenPosaoTableAdapter.ClearBeforeFill = true;
            // 
            // zgradaTableAdapter
            // 
            this.zgradaTableAdapter.ClearBeforeFill = true;
            // 
            // PregledPremaOdabranomPartneruForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 404);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PregledPremaOdabranomPartneruForma";
            this.Text = "Pregled poslova";
            this.Load += new System.EventHandler(this.PregledPremaOdabranomPartneruForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorenPosaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_18082 dB_18082;
        private System.Windows.Forms.BindingSource mogucPosaoBindingSource;
        private DB_18082TableAdapters.MogucPosaoTableAdapter mogucPosaoTableAdapter;
        private System.Windows.Forms.BindingSource ugovorenPosaoBindingSource;
        private DB_18082TableAdapters.UgovorenPosaoTableAdapter ugovorenPosaoTableAdapter;
        private System.Windows.Forms.BindingSource zgradaBindingSource;
        private DB_18082TableAdapters.ZgradaTableAdapter zgradaTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn zgradaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvrtkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn moguciPosloviIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mogucPosaoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetakRadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajRadaDataGridViewTextBoxColumn;
    }
}