namespace LoginForma
{
    partial class DodijeliPosaoPopUpForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodijeliPosaoPopUpForma));
            this.btnDodijeliPosao = new System.Windows.Forms.Button();
            this.btnDodajPartnera = new System.Windows.Forms.Button();
            this.btnDodajPosao = new System.Windows.Forms.Button();
            this.btnObrisiPartnera = new System.Windows.Forms.Button();
            this.btnObrisiPosao = new System.Windows.Forms.Button();
            this.btnAzurirajPartnera = new System.Windows.Forms.Button();
            this.btnAzurirajPosao = new System.Windows.Forms.Button();
            this.txtCijenaPosla = new System.Windows.Forms.TextBox();
            this.dtpDatumZavrsetkaPosla = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPocetkaPosla = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPopisPartnera = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojMobitelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_18082 = new LoginForma.DB_18082();
            this.dgvPopisPoslova = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mogucPosaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mogucPosaoTableAdapter = new LoginForma.DB_18082TableAdapters.MogucPosaoTableAdapter();
            this.partnerTableAdapter = new LoginForma.DB_18082TableAdapters.PartnerTableAdapter();
            this.ugovorenPosaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorenPosaoTableAdapter = new LoginForma.DB_18082TableAdapters.UgovorenPosaoTableAdapter();
            this.tableAdapterManager = new LoginForma.DB_18082TableAdapters.TableAdapterManager();
            this.btnPregledPremaOdabranomPoslu = new System.Windows.Forms.Button();
            this.btnPregledPremaOdabranomPartneru = new System.Windows.Forms.Button();
            this.txtPretragaPosla = new System.Windows.Forms.TextBox();
            this.txtPretragaPartnera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPartnera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoslova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorenPosaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodijeliPosao
            // 
            this.btnDodijeliPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodijeliPosao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnDodijeliPosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodijeliPosao.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodijeliPosao.ForeColor = System.Drawing.Color.White;
            this.btnDodijeliPosao.Location = new System.Drawing.Point(390, 432);
            this.btnDodijeliPosao.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodijeliPosao.Name = "btnDodijeliPosao";
            this.btnDodijeliPosao.Size = new System.Drawing.Size(378, 53);
            this.btnDodijeliPosao.TabIndex = 11;
            this.btnDodijeliPosao.Text = "Dodijeli posao";
            this.btnDodijeliPosao.UseVisualStyleBackColor = false;
            this.btnDodijeliPosao.Click += new System.EventHandler(this.btnDodijeliPosao_Click);
            // 
            // btnDodajPartnera
            // 
            this.btnDodajPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajPartnera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPartnera.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDodajPartnera.ForeColor = System.Drawing.Color.White;
            this.btnDodajPartnera.Location = new System.Drawing.Point(573, 294);
            this.btnDodajPartnera.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajPartnera.Name = "btnDodajPartnera";
            this.btnDodajPartnera.Size = new System.Drawing.Size(82, 43);
            this.btnDodajPartnera.TabIndex = 4;
            this.btnDodajPartnera.Text = "Dodaj partnera";
            this.btnDodajPartnera.UseVisualStyleBackColor = false;
            this.btnDodajPartnera.Click += new System.EventHandler(this.btnDodajPartnera_Click);
            // 
            // btnDodajPosao
            // 
            this.btnDodajPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajPosao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodajPosao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajPosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajPosao.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDodajPosao.ForeColor = System.Drawing.Color.White;
            this.btnDodajPosao.Location = new System.Drawing.Point(11, 295);
            this.btnDodajPosao.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajPosao.Name = "btnDodajPosao";
            this.btnDodajPosao.Size = new System.Drawing.Size(82, 43);
            this.btnDodajPosao.TabIndex = 0;
            this.btnDodajPosao.Text = "Dodaj posao";
            this.btnDodajPosao.UseVisualStyleBackColor = false;
            this.btnDodajPosao.Click += new System.EventHandler(this.btnDodajPosao_Click);
            // 
            // btnObrisiPartnera
            // 
            this.btnObrisiPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiPartnera.BackColor = System.Drawing.Color.Crimson;
            this.btnObrisiPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPartnera.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnObrisiPartnera.ForeColor = System.Drawing.Color.White;
            this.btnObrisiPartnera.Location = new System.Drawing.Point(754, 295);
            this.btnObrisiPartnera.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiPartnera.Name = "btnObrisiPartnera";
            this.btnObrisiPartnera.Size = new System.Drawing.Size(90, 42);
            this.btnObrisiPartnera.TabIndex = 6;
            this.btnObrisiPartnera.Text = "Obriši partnera";
            this.btnObrisiPartnera.UseVisualStyleBackColor = false;
            this.btnObrisiPartnera.Click += new System.EventHandler(this.btnObrisiPartnera_Click);
            // 
            // btnObrisiPosao
            // 
            this.btnObrisiPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiPosao.BackColor = System.Drawing.Color.Crimson;
            this.btnObrisiPosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPosao.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnObrisiPosao.ForeColor = System.Drawing.Color.White;
            this.btnObrisiPosao.Location = new System.Drawing.Point(192, 295);
            this.btnObrisiPosao.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiPosao.Name = "btnObrisiPosao";
            this.btnObrisiPosao.Size = new System.Drawing.Size(79, 43);
            this.btnObrisiPosao.TabIndex = 2;
            this.btnObrisiPosao.Text = "Obriši posao";
            this.btnObrisiPosao.UseVisualStyleBackColor = false;
            this.btnObrisiPosao.Click += new System.EventHandler(this.btnObrisiPosao_Click);
            // 
            // btnAzurirajPartnera
            // 
            this.btnAzurirajPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAzurirajPartnera.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzurirajPartnera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajPartnera.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnAzurirajPartnera.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajPartnera.Location = new System.Drawing.Point(659, 295);
            this.btnAzurirajPartnera.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzurirajPartnera.Name = "btnAzurirajPartnera";
            this.btnAzurirajPartnera.Size = new System.Drawing.Size(91, 42);
            this.btnAzurirajPartnera.TabIndex = 5;
            this.btnAzurirajPartnera.Text = "Ažuriraj partnera";
            this.btnAzurirajPartnera.UseVisualStyleBackColor = false;
            this.btnAzurirajPartnera.Click += new System.EventHandler(this.btnAzurirajPartnera_Click);
            // 
            // btnAzurirajPosao
            // 
            this.btnAzurirajPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAzurirajPosao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzurirajPosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajPosao.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnAzurirajPosao.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajPosao.Location = new System.Drawing.Point(97, 295);
            this.btnAzurirajPosao.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzurirajPosao.Name = "btnAzurirajPosao";
            this.btnAzurirajPosao.Size = new System.Drawing.Size(91, 43);
            this.btnAzurirajPosao.TabIndex = 1;
            this.btnAzurirajPosao.Text = "Ažuriraj posao";
            this.btnAzurirajPosao.UseVisualStyleBackColor = false;
            this.btnAzurirajPosao.Click += new System.EventHandler(this.btnAzurirajPosao_Click);
            // 
            // txtCijenaPosla
            // 
            this.txtCijenaPosla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCijenaPosla.Location = new System.Drawing.Point(679, 383);
            this.txtCijenaPosla.Name = "txtCijenaPosla";
            this.txtCijenaPosla.Size = new System.Drawing.Size(158, 20);
            this.txtCijenaPosla.TabIndex = 10;
            // 
            // dtpDatumZavrsetkaPosla
            // 
            this.dtpDatumZavrsetkaPosla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDatumZavrsetkaPosla.Location = new System.Drawing.Point(506, 383);
            this.dtpDatumZavrsetkaPosla.Name = "dtpDatumZavrsetkaPosla";
            this.dtpDatumZavrsetkaPosla.Size = new System.Drawing.Size(167, 20);
            this.dtpDatumZavrsetkaPosla.TabIndex = 9;
            // 
            // dtpDatumPocetkaPosla
            // 
            this.dtpDatumPocetkaPosla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDatumPocetkaPosla.Location = new System.Drawing.Point(330, 383);
            this.dtpDatumPocetkaPosla.Name = "dtpDatumPocetkaPosla";
            this.dtpDatumPocetkaPosla.Size = new System.Drawing.Size(168, 20);
            this.dtpDatumPocetkaPosla.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Datum završetka  posla";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cijena posla u kunama";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Datum početka posla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Popis partnera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Popis poslova";
            // 
            // dgvPopisPartnera
            // 
            this.dgvPopisPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisPartnera.AutoGenerateColumns = false;
            this.dgvPopisPartnera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPartnera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.brojMobitelaDataGridViewTextBoxColumn});
            this.dgvPopisPartnera.DataSource = this.partnerBindingSource;
            this.dgvPopisPartnera.Location = new System.Drawing.Point(569, 38);
            this.dgvPopisPartnera.MultiSelect = false;
            this.dgvPopisPartnera.Name = "dgvPopisPartnera";
            this.dgvPopisPartnera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisPartnera.Size = new System.Drawing.Size(556, 251);
            this.dgvPopisPartnera.TabIndex = 46;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // brojMobitelaDataGridViewTextBoxColumn
            // 
            this.brojMobitelaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojMobitelaDataGridViewTextBoxColumn.DataPropertyName = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.HeaderText = "BrojMobitela";
            this.brojMobitelaDataGridViewTextBoxColumn.Name = "brojMobitelaDataGridViewTextBoxColumn";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "Partner";
            this.partnerBindingSource.DataSource = this.dB_18082;
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPopisPoslova
            // 
            this.dgvPopisPoslova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisPoslova.AutoGenerateColumns = false;
            this.dgvPopisPoslova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPoslova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dgvPopisPoslova.DataSource = this.mogucPosaoBindingSource;
            this.dgvPopisPoslova.Location = new System.Drawing.Point(11, 37);
            this.dgvPopisPoslova.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPopisPoslova.MultiSelect = false;
            this.dgvPopisPoslova.Name = "dgvPopisPoslova";
            this.dgvPopisPoslova.RowTemplate.Height = 24;
            this.dgvPopisPoslova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisPoslova.Size = new System.Drawing.Size(544, 252);
            this.dgvPopisPoslova.TabIndex = 45;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
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
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // ugovorenPosaoBindingSource
            // 
            this.ugovorenPosaoBindingSource.DataMember = "UgovorenPosao";
            this.ugovorenPosaoBindingSource.DataSource = this.dB_18082;
            // 
            // ugovorenPosaoTableAdapter
            // 
            this.ugovorenPosaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KatTableAdapter = null;
            this.tableAdapterManager.MogucPosaoTableAdapter = this.mogucPosaoTableAdapter;
            this.tableAdapterManager.PartnerTableAdapter = this.partnerTableAdapter;
            this.tableAdapterManager.StanarTableAdapter = null;
            this.tableAdapterManager.StanTableAdapter = null;
            this.tableAdapterManager.UgovorenPosaoTableAdapter = this.ugovorenPosaoTableAdapter;
            this.tableAdapterManager.UlazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginForma.DB_18082TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UplatnicaTableAdapter = null;
            this.tableAdapterManager.VlasnikTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            this.tableAdapterManager.ZgradaTableAdapter = null;
            // 
            // btnPregledPremaOdabranomPoslu
            // 
            this.btnPregledPremaOdabranomPoslu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPregledPremaOdabranomPoslu.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPregledPremaOdabranomPoslu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledPremaOdabranomPoslu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnPregledPremaOdabranomPoslu.ForeColor = System.Drawing.Color.White;
            this.btnPregledPremaOdabranomPoslu.Location = new System.Drawing.Point(275, 295);
            this.btnPregledPremaOdabranomPoslu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPregledPremaOdabranomPoslu.Name = "btnPregledPremaOdabranomPoslu";
            this.btnPregledPremaOdabranomPoslu.Size = new System.Drawing.Size(135, 43);
            this.btnPregledPremaOdabranomPoslu.TabIndex = 3;
            this.btnPregledPremaOdabranomPoslu.Text = "Pregled prema odabranom poslu";
            this.btnPregledPremaOdabranomPoslu.UseVisualStyleBackColor = false;
            this.btnPregledPremaOdabranomPoslu.Click += new System.EventHandler(this.btnPregledPoslovaPoZgradi_Click);
            // 
            // btnPregledPremaOdabranomPartneru
            // 
            this.btnPregledPremaOdabranomPartneru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregledPremaOdabranomPartneru.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPregledPremaOdabranomPartneru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledPremaOdabranomPartneru.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnPregledPremaOdabranomPartneru.ForeColor = System.Drawing.Color.White;
            this.btnPregledPremaOdabranomPartneru.Location = new System.Drawing.Point(850, 295);
            this.btnPregledPremaOdabranomPartneru.Margin = new System.Windows.Forms.Padding(2);
            this.btnPregledPremaOdabranomPartneru.Name = "btnPregledPremaOdabranomPartneru";
            this.btnPregledPremaOdabranomPartneru.Size = new System.Drawing.Size(135, 43);
            this.btnPregledPremaOdabranomPartneru.TabIndex = 7;
            this.btnPregledPremaOdabranomPartneru.Text = "Pregled prema odabranom partneru";
            this.btnPregledPremaOdabranomPartneru.UseVisualStyleBackColor = false;
            this.btnPregledPremaOdabranomPartneru.Click += new System.EventHandler(this.btnPregledPremaOdabranomPartneru_Click);
            // 
            // txtPretragaPosla
            // 
            this.txtPretragaPosla.Location = new System.Drawing.Point(410, 12);
            this.txtPretragaPosla.Name = "txtPretragaPosla";
            this.txtPretragaPosla.Size = new System.Drawing.Size(145, 20);
            this.txtPretragaPosla.TabIndex = 52;
            this.txtPretragaPosla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretragaPosla_KeyUp);
            // 
            // txtPretragaPartnera
            // 
            this.txtPretragaPartnera.Location = new System.Drawing.Point(980, 12);
            this.txtPretragaPartnera.Name = "txtPretragaPartnera";
            this.txtPretragaPartnera.Size = new System.Drawing.Size(145, 20);
            this.txtPretragaPartnera.TabIndex = 52;
            this.txtPretragaPartnera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretragaPartnera_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Pretraži poslove po nazivu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Pretraži partnere po nazivu:";
            // 
            // DodijeliPosaoPopUpForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPretragaPartnera);
            this.Controls.Add(this.txtPretragaPosla);
            this.Controls.Add(this.btnPregledPremaOdabranomPartneru);
            this.Controls.Add(this.btnPregledPremaOdabranomPoslu);
            this.Controls.Add(this.btnDodijeliPosao);
            this.Controls.Add(this.btnDodajPartnera);
            this.Controls.Add(this.btnDodajPosao);
            this.Controls.Add(this.btnObrisiPartnera);
            this.Controls.Add(this.btnObrisiPosao);
            this.Controls.Add(this.btnAzurirajPartnera);
            this.Controls.Add(this.btnAzurirajPosao);
            this.Controls.Add(this.txtCijenaPosla);
            this.Controls.Add(this.dtpDatumZavrsetkaPosla);
            this.Controls.Add(this.dtpDatumPocetkaPosla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisPartnera);
            this.Controls.Add(this.dgvPopisPoslova);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodijeliPosaoPopUpForma";
            this.Text = "Dodijeli posao";
            this.Load += new System.EventHandler(this.DodijeliPosaoPopUpForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPartnera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoslova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorenPosaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodijeliPosao;
        private System.Windows.Forms.Button btnDodajPartnera;
        private System.Windows.Forms.Button btnDodajPosao;
        private System.Windows.Forms.Button btnObrisiPartnera;
        private System.Windows.Forms.Button btnObrisiPosao;
        private System.Windows.Forms.Button btnAzurirajPartnera;
        private System.Windows.Forms.Button btnAzurirajPosao;
        private System.Windows.Forms.TextBox txtCijenaPosla;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetkaPosla;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetkaPosla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisPartnera;
        private System.Windows.Forms.DataGridView dgvPopisPoslova;
        private DB_18082 dB_18082;
        private System.Windows.Forms.BindingSource mogucPosaoBindingSource;
        private DB_18082TableAdapters.MogucPosaoTableAdapter mogucPosaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private DB_18082TableAdapters.PartnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMobitelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ugovorenPosaoBindingSource;
        private DB_18082TableAdapters.UgovorenPosaoTableAdapter ugovorenPosaoTableAdapter;
        private DB_18082TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnPregledPremaOdabranomPoslu;
        private System.Windows.Forms.Button btnPregledPremaOdabranomPartneru;
        private System.Windows.Forms.TextBox txtPretragaPosla;
        private System.Windows.Forms.TextBox txtPretragaPartnera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}