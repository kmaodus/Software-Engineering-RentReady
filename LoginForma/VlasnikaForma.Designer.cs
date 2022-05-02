namespace LoginForma
{
    partial class VlasnikaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VlasnikaForma));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZaposlenici = new System.Windows.Forms.TabPage();
            this.PopisZaposlenikaGrid = new System.Windows.Forms.DataGridView();
            this.btnKontaktirajZaposlenika = new System.Windows.Forms.Button();
            this.btnBrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnAzurirajZaposlenika = new System.Windows.Forms.Button();
            this.tabZgrade = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnDodijeliPosao = new System.Windows.Forms.Button();
            this.dgvPopisZgrada = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_18082 = new LoginForma.DB_18082();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zgradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrisiZgradu = new System.Windows.Forms.Button();
            this.btnDodajZgradu = new System.Windows.Forms.Button();
            this.btnAzurirajZgradu = new System.Windows.Forms.Button();
            this.tabStanari = new System.Windows.Forms.TabPage();
            this.prikaziSveStanareButton = new System.Windows.Forms.Button();
            this.traziStanaraButton = new System.Windows.Forms.Button();
            this.uvjetTrazenjaStanaraTextBox = new System.Windows.Forms.TextBox();
            this.stanariDataGrid = new System.Windows.Forms.DataGridView();
            this.kontaktirajStanaraButton = new System.Windows.Forms.Button();
            this.brisiStanaraButton = new System.Windows.Forms.Button();
            this.dodajStanaraButton = new System.Windows.Forms.Button();
            this.azurirajStanareButton = new System.Windows.Forms.Button();
            this.tabIzvještaji = new System.Windows.Forms.TabPage();
            this.btnIspisTroskovaUPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStanovi = new System.Windows.Forms.ComboBox();
            this.stanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbKatovi = new System.Windows.Forms.ComboBox();
            this.katBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbUlazi = new System.Windows.Forms.ComboBox();
            this.ulazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZgradePopisLabel = new System.Windows.Forms.Label();
            this.dgvPopisTroskova = new System.Windows.Forms.DataGridView();
            this.cbZgrade = new System.Windows.Forms.ComboBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zgradaTableAdapter = new LoginForma.DB_18082TableAdapters.ZgradaTableAdapter();
            this.zaposlenikTableAdapter = new LoginForma.DB_18082TableAdapters.ZaposlenikTableAdapter();
            this.vlasnikTableAdapter = new LoginForma.DB_18082TableAdapters.VlasnikTableAdapter();
            this.ulazTableAdapter = new LoginForma.DB_18082TableAdapters.UlazTableAdapter();
            this.katTableAdapter = new LoginForma.DB_18082TableAdapters.KatTableAdapter();
            this.stanTableAdapter = new LoginForma.DB_18082TableAdapters.StanTableAdapter();
            this.zgradaTableAdapter1 = new LoginForma.DB_18082TableAdapters.ZgradaTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.zgradaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prikaziDugovanjaButton = new System.Windows.Forms.Button();
            this.placenoDugovanjeButton = new System.Windows.Forms.Button();
            this.noviMjesecButton = new System.Windows.Forms.Button();
            this.posaljiUplatniceButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabZaposlenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisZaposlenikaGrid)).BeginInit();
            this.tabZgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZgrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).BeginInit();
            this.tabStanari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanariDataGrid)).BeginInit();
            this.tabIzvještaji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTroskova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabZaposlenici);
            this.tabControl1.Controls.Add(this.tabZgrade);
            this.tabControl1.Controls.Add(this.tabStanari);
            this.tabControl1.Controls.Add(this.tabIzvještaji);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(19, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 640);
            this.tabControl1.TabIndex = 0;
            // 
            // tabZaposlenici
            // 
            this.tabZaposlenici.Controls.Add(this.PopisZaposlenikaGrid);
            this.tabZaposlenici.Controls.Add(this.btnKontaktirajZaposlenika);
            this.tabZaposlenici.Controls.Add(this.btnBrisiZaposlenika);
            this.tabZaposlenici.Controls.Add(this.btnDodajZaposlenika);
            this.tabZaposlenici.Controls.Add(this.btnAzurirajZaposlenika);
            this.tabZaposlenici.Location = new System.Drawing.Point(4, 30);
            this.tabZaposlenici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZaposlenici.Name = "tabZaposlenici";
            this.tabZaposlenici.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZaposlenici.Size = new System.Drawing.Size(1421, 606);
            this.tabZaposlenici.TabIndex = 0;
            this.tabZaposlenici.Text = "Zaposlenici";
            this.tabZaposlenici.UseVisualStyleBackColor = true;
            // 
            // PopisZaposlenikaGrid
            // 
            this.PopisZaposlenikaGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopisZaposlenikaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisZaposlenikaGrid.Location = new System.Drawing.Point(132, 34);
            this.PopisZaposlenikaGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopisZaposlenikaGrid.Name = "PopisZaposlenikaGrid";
            this.PopisZaposlenikaGrid.RowTemplate.Height = 24;
            this.PopisZaposlenikaGrid.Size = new System.Drawing.Size(1281, 561);
            this.PopisZaposlenikaGrid.TabIndex = 41;
            // 
            // btnKontaktirajZaposlenika
            // 
            this.btnKontaktirajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKontaktirajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnKontaktirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontaktirajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnKontaktirajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnKontaktirajZaposlenika.Location = new System.Drawing.Point(5, 545);
            this.btnKontaktirajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKontaktirajZaposlenika.Name = "btnKontaktirajZaposlenika";
            this.btnKontaktirajZaposlenika.Size = new System.Drawing.Size(121, 50);
            this.btnKontaktirajZaposlenika.TabIndex = 40;
            this.btnKontaktirajZaposlenika.Text = "Kontaktiraj";
            this.btnKontaktirajZaposlenika.UseVisualStyleBackColor = false;
            // 
            // btnBrisiZaposlenika
            // 
            this.btnBrisiZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiZaposlenika.BackColor = System.Drawing.Color.Crimson;
            this.btnBrisiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisiZaposlenika.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnBrisiZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnBrisiZaposlenika.Location = new System.Drawing.Point(5, 490);
            this.btnBrisiZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrisiZaposlenika.Name = "btnBrisiZaposlenika";
            this.btnBrisiZaposlenika.Size = new System.Drawing.Size(121, 50);
            this.btnBrisiZaposlenika.TabIndex = 39;
            this.btnBrisiZaposlenika.Text = "Briši";
            this.btnBrisiZaposlenika.UseVisualStyleBackColor = false;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(5, 434);
            this.btnDodajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(121, 50);
            this.btnDodajZaposlenika.TabIndex = 38;
            this.btnDodajZaposlenika.Text = "Dodaj";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            // 
            // btnAzurirajZaposlenika
            // 
            this.btnAzurirajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAzurirajZaposlenika.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzurirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnAzurirajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajZaposlenika.Location = new System.Drawing.Point(5, 379);
            this.btnAzurirajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajZaposlenika.Name = "btnAzurirajZaposlenika";
            this.btnAzurirajZaposlenika.Size = new System.Drawing.Size(121, 50);
            this.btnAzurirajZaposlenika.TabIndex = 37;
            this.btnAzurirajZaposlenika.Text = "Ažuriraj";
            this.btnAzurirajZaposlenika.UseVisualStyleBackColor = false;
            // 
            // tabZgrade
            // 
            this.tabZgrade.Controls.Add(this.label4);
            this.tabZgrade.Controls.Add(this.txtPretrazi);
            this.tabZgrade.Controls.Add(this.btnDodijeliPosao);
            this.tabZgrade.Controls.Add(this.dgvPopisZgrada);
            this.tabZgrade.Controls.Add(this.btnBrisiZgradu);
            this.tabZgrade.Controls.Add(this.btnDodajZgradu);
            this.tabZgrade.Controls.Add(this.btnAzurirajZgradu);
            this.tabZgrade.Location = new System.Drawing.Point(4, 30);
            this.tabZgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZgrade.Name = "tabZgrade";
            this.tabZgrade.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZgrade.Size = new System.Drawing.Size(1421, 606);
            this.tabZgrade.TabIndex = 1;
            this.tabZgrade.Text = "Zgrade";
            this.tabZgrade.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(921, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Pretraži po lokaciji:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretrazi.Location = new System.Drawing.Point(1121, 6);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(289, 30);
            this.txtPretrazi.TabIndex = 48;
            this.txtPretrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretrazi_KeyUp);
            // 
            // btnDodijeliPosao
            // 
            this.btnDodijeliPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodijeliPosao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnDodijeliPosao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodijeliPosao.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDodijeliPosao.ForeColor = System.Drawing.Color.White;
            this.btnDodijeliPosao.Location = new System.Drawing.Point(5, 530);
            this.btnDodijeliPosao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodijeliPosao.Name = "btnDodijeliPosao";
            this.btnDodijeliPosao.Size = new System.Drawing.Size(121, 65);
            this.btnDodijeliPosao.TabIndex = 47;
            this.btnDodijeliPosao.Text = "Dodijeli posao";
            this.btnDodijeliPosao.UseVisualStyleBackColor = false;
            this.btnDodijeliPosao.Click += new System.EventHandler(this.btnDodijeliPosao_Click);
            // 
            // dgvPopisZgrada
            // 
            this.dgvPopisZgrada.AllowUserToAddRows = false;
            this.dgvPopisZgrada.AllowUserToDeleteRows = false;
            this.dgvPopisZgrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisZgrada.AutoGenerateColumns = false;
            this.dgvPopisZgrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZgrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.zaposlenikIDDataGridViewTextBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn,
            this.vlasnikIDDataGridViewTextBoxColumn});
            this.dgvPopisZgrada.DataSource = this.zgradaBindingSource;
            this.dgvPopisZgrada.Location = new System.Drawing.Point(132, 34);
            this.dgvPopisZgrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPopisZgrada.MultiSelect = false;
            this.dgvPopisZgrada.Name = "dgvPopisZgrada";
            this.dgvPopisZgrada.ReadOnly = true;
            this.dgvPopisZgrada.RowTemplate.Height = 24;
            this.dgvPopisZgrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZgrada.Size = new System.Drawing.Size(1281, 550);
            this.dgvPopisZgrada.TabIndex = 46;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // zaposlenikIDDataGridViewTextBoxColumn
            // 
            this.zaposlenikIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zaposlenikIDDataGridViewTextBoxColumn.DataPropertyName = "ZaposlenikID";
            this.zaposlenikIDDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.zaposlenikIDDataGridViewTextBoxColumn.DisplayMember = "Prezime";
            this.zaposlenikIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikIDDataGridViewTextBoxColumn.HeaderText = "Prezime zaposlenika";
            this.zaposlenikIDDataGridViewTextBoxColumn.Name = "zaposlenikIDDataGridViewTextBoxColumn";
            this.zaposlenikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.dB_18082;
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            this.lokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlasnikIDDataGridViewTextBoxColumn
            // 
            this.vlasnikIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vlasnikIDDataGridViewTextBoxColumn.DataPropertyName = "VlasnikID";
            this.vlasnikIDDataGridViewTextBoxColumn.DataSource = this.vlasnikBindingSource;
            this.vlasnikIDDataGridViewTextBoxColumn.DisplayMember = "Prezime";
            this.vlasnikIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vlasnikIDDataGridViewTextBoxColumn.HeaderText = "VlasnikID";
            this.vlasnikIDDataGridViewTextBoxColumn.Name = "vlasnikIDDataGridViewTextBoxColumn";
            this.vlasnikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlasnikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vlasnikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vlasnikIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.vlasnikIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "Vlasnik";
            this.vlasnikBindingSource.DataSource = this.dB_18082;
            // 
            // zgradaBindingSource
            // 
            this.zgradaBindingSource.DataMember = "Zgrada";
            this.zgradaBindingSource.DataSource = this.dB_18082;
            // 
            // btnBrisiZgradu
            // 
            this.btnBrisiZgradu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiZgradu.BackColor = System.Drawing.Color.Crimson;
            this.btnBrisiZgradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisiZgradu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnBrisiZgradu.ForeColor = System.Drawing.Color.White;
            this.btnBrisiZgradu.Location = new System.Drawing.Point(5, 475);
            this.btnBrisiZgradu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrisiZgradu.Name = "btnBrisiZgradu";
            this.btnBrisiZgradu.Size = new System.Drawing.Size(121, 50);
            this.btnBrisiZgradu.TabIndex = 45;
            this.btnBrisiZgradu.Text = "Briši";
            this.btnBrisiZgradu.UseVisualStyleBackColor = false;
            this.btnBrisiZgradu.Click += new System.EventHandler(this.btnBrisiZgradu_Click);
            // 
            // btnDodajZgradu
            // 
            this.btnDodajZgradu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajZgradu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDodajZgradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZgradu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnDodajZgradu.ForeColor = System.Drawing.Color.White;
            this.btnDodajZgradu.Location = new System.Drawing.Point(5, 420);
            this.btnDodajZgradu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajZgradu.Name = "btnDodajZgradu";
            this.btnDodajZgradu.Size = new System.Drawing.Size(121, 50);
            this.btnDodajZgradu.TabIndex = 44;
            this.btnDodajZgradu.Text = "Dodaj";
            this.btnDodajZgradu.UseVisualStyleBackColor = false;
            this.btnDodajZgradu.Click += new System.EventHandler(this.btnDodajZgradu_Click);
            // 
            // btnAzurirajZgradu
            // 
            this.btnAzurirajZgradu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAzurirajZgradu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzurirajZgradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajZgradu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnAzurirajZgradu.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajZgradu.Location = new System.Drawing.Point(5, 364);
            this.btnAzurirajZgradu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAzurirajZgradu.Name = "btnAzurirajZgradu";
            this.btnAzurirajZgradu.Size = new System.Drawing.Size(121, 50);
            this.btnAzurirajZgradu.TabIndex = 43;
            this.btnAzurirajZgradu.Text = "Ažuriraj";
            this.btnAzurirajZgradu.UseVisualStyleBackColor = false;
            this.btnAzurirajZgradu.Click += new System.EventHandler(this.btnAzurirajZgradu_Click);
            // 
            // tabStanari
            // 
            this.tabStanari.Controls.Add(this.posaljiUplatniceButton);
            this.tabStanari.Controls.Add(this.noviMjesecButton);
            this.tabStanari.Controls.Add(this.placenoDugovanjeButton);
            this.tabStanari.Controls.Add(this.prikaziDugovanjaButton);
            this.tabStanari.Controls.Add(this.prikaziSveStanareButton);
            this.tabStanari.Controls.Add(this.traziStanaraButton);
            this.tabStanari.Controls.Add(this.uvjetTrazenjaStanaraTextBox);
            this.tabStanari.Controls.Add(this.stanariDataGrid);
            this.tabStanari.Controls.Add(this.kontaktirajStanaraButton);
            this.tabStanari.Controls.Add(this.brisiStanaraButton);
            this.tabStanari.Controls.Add(this.dodajStanaraButton);
            this.tabStanari.Controls.Add(this.azurirajStanareButton);
            this.tabStanari.Location = new System.Drawing.Point(4, 30);
            this.tabStanari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStanari.Name = "tabStanari";
            this.tabStanari.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStanari.Size = new System.Drawing.Size(1421, 606);
            this.tabStanari.TabIndex = 2;
            this.tabStanari.Text = "Stanari";
            this.tabStanari.UseVisualStyleBackColor = true;
            // 
            // prikaziSveStanareButton
            // 
            this.prikaziSveStanareButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.prikaziSveStanareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziSveStanareButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.prikaziSveStanareButton.ForeColor = System.Drawing.Color.White;
            this.prikaziSveStanareButton.Location = new System.Drawing.Point(7, 123);
            this.prikaziSveStanareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziSveStanareButton.Name = "prikaziSveStanareButton";
            this.prikaziSveStanareButton.Size = new System.Drawing.Size(121, 50);
            this.prikaziSveStanareButton.TabIndex = 48;
            this.prikaziSveStanareButton.Text = "Prikaži sve";
            this.prikaziSveStanareButton.UseVisualStyleBackColor = false;
            this.prikaziSveStanareButton.Click += new System.EventHandler(this.prikaziSveStanareButton_Click);
            // 
            // traziStanaraButton
            // 
            this.traziStanaraButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.traziStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traziStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.traziStanaraButton.ForeColor = System.Drawing.Color.White;
            this.traziStanaraButton.Location = new System.Drawing.Point(7, 69);
            this.traziStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.traziStanaraButton.Name = "traziStanaraButton";
            this.traziStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.traziStanaraButton.TabIndex = 47;
            this.traziStanaraButton.Text = "Traži";
            this.traziStanaraButton.UseVisualStyleBackColor = false;
            this.traziStanaraButton.Click += new System.EventHandler(this.traziStanaraButton_Click_1);
            // 
            // uvjetTrazenjaStanaraTextBox
            // 
            this.uvjetTrazenjaStanaraTextBox.Location = new System.Drawing.Point(8, 34);
            this.uvjetTrazenjaStanaraTextBox.Name = "uvjetTrazenjaStanaraTextBox";
            this.uvjetTrazenjaStanaraTextBox.Size = new System.Drawing.Size(120, 30);
            this.uvjetTrazenjaStanaraTextBox.TabIndex = 46;
            // 
            // stanariDataGrid
            // 
            this.stanariDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stanariDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stanariDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stanariDataGrid.Location = new System.Drawing.Point(132, 34);
            this.stanariDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stanariDataGrid.Name = "stanariDataGrid";
            this.stanariDataGrid.RowTemplate.Height = 24;
            this.stanariDataGrid.Size = new System.Drawing.Size(1281, 561);
            this.stanariDataGrid.TabIndex = 41;
            // 
            // kontaktirajStanaraButton
            // 
            this.kontaktirajStanaraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kontaktirajStanaraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.kontaktirajStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kontaktirajStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.kontaktirajStanaraButton.ForeColor = System.Drawing.Color.White;
            this.kontaktirajStanaraButton.Location = new System.Drawing.Point(5, 545);
            this.kontaktirajStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kontaktirajStanaraButton.Name = "kontaktirajStanaraButton";
            this.kontaktirajStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.kontaktirajStanaraButton.TabIndex = 40;
            this.kontaktirajStanaraButton.Text = "Kontaktiraj";
            this.kontaktirajStanaraButton.UseVisualStyleBackColor = false;
            this.kontaktirajStanaraButton.Click += new System.EventHandler(this.kontaktirajStanaraButton_Click);
            // 
            // brisiStanaraButton
            // 
            this.brisiStanaraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brisiStanaraButton.BackColor = System.Drawing.Color.Crimson;
            this.brisiStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brisiStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.brisiStanaraButton.ForeColor = System.Drawing.Color.White;
            this.brisiStanaraButton.Location = new System.Drawing.Point(5, 490);
            this.brisiStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brisiStanaraButton.Name = "brisiStanaraButton";
            this.brisiStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.brisiStanaraButton.TabIndex = 39;
            this.brisiStanaraButton.Text = "Briši";
            this.brisiStanaraButton.UseVisualStyleBackColor = false;
            this.brisiStanaraButton.Click += new System.EventHandler(this.brisiStanaraButton_Click);
            // 
            // dodajStanaraButton
            // 
            this.dodajStanaraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dodajStanaraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dodajStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dodajStanaraButton.ForeColor = System.Drawing.Color.White;
            this.dodajStanaraButton.Location = new System.Drawing.Point(5, 434);
            this.dodajStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajStanaraButton.Name = "dodajStanaraButton";
            this.dodajStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.dodajStanaraButton.TabIndex = 38;
            this.dodajStanaraButton.Text = "Dodaj";
            this.dodajStanaraButton.UseVisualStyleBackColor = false;
            this.dodajStanaraButton.Click += new System.EventHandler(this.dodajStanaraButton_Click);
            // 
            // azurirajStanareButton
            // 
            this.azurirajStanareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.azurirajStanareButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.azurirajStanareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azurirajStanareButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.azurirajStanareButton.ForeColor = System.Drawing.Color.White;
            this.azurirajStanareButton.Location = new System.Drawing.Point(5, 379);
            this.azurirajStanareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajStanareButton.Name = "azurirajStanareButton";
            this.azurirajStanareButton.Size = new System.Drawing.Size(121, 50);
            this.azurirajStanareButton.TabIndex = 37;
            this.azurirajStanareButton.Text = "Ažuriraj";
            this.azurirajStanareButton.UseVisualStyleBackColor = false;
            this.azurirajStanareButton.Click += new System.EventHandler(this.azurirajStanareButton_Click);
            // 
            // tabIzvještaji
            // 
            this.tabIzvještaji.Controls.Add(this.btnIspisTroskovaUPDF);
            this.tabIzvještaji.Controls.Add(this.label3);
            this.tabIzvještaji.Controls.Add(this.cbStanovi);
            this.tabIzvještaji.Controls.Add(this.label2);
            this.tabIzvještaji.Controls.Add(this.cbKatovi);
            this.tabIzvještaji.Controls.Add(this.label1);
            this.tabIzvještaji.Controls.Add(this.cbUlazi);
            this.tabIzvještaji.Controls.Add(this.ZgradePopisLabel);
            this.tabIzvještaji.Controls.Add(this.dgvPopisTroskova);
            this.tabIzvještaji.Controls.Add(this.cbZgrade);
            this.tabIzvještaji.Location = new System.Drawing.Point(4, 30);
            this.tabIzvještaji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIzvještaji.Name = "tabIzvještaji";
            this.tabIzvještaji.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIzvještaji.Size = new System.Drawing.Size(1421, 606);
            this.tabIzvještaji.TabIndex = 3;
            this.tabIzvještaji.Text = "Izvještaji";
            this.tabIzvještaji.UseVisualStyleBackColor = true;
            // 
            // btnIspisTroskovaUPDF
            // 
            this.btnIspisTroskovaUPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIspisTroskovaUPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIspisTroskovaUPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnIspisTroskovaUPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisTroskovaUPDF.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnIspisTroskovaUPDF.ForeColor = System.Drawing.Color.White;
            this.btnIspisTroskovaUPDF.Location = new System.Drawing.Point(1171, 5);
            this.btnIspisTroskovaUPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIspisTroskovaUPDF.Name = "btnIspisTroskovaUPDF";
            this.btnIspisTroskovaUPDF.Size = new System.Drawing.Size(241, 145);
            this.btnIspisTroskovaUPDF.TabIndex = 4;
            this.btnIspisTroskovaUPDF.Text = "PDF";
            this.btnIspisTroskovaUPDF.UseVisualStyleBackColor = false;
            this.btnIspisTroskovaUPDF.Click += new System.EventHandler(this.btnIspisTroskovaUPDF_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Popis stanova";
            // 
            // cbStanovi
            // 
            this.cbStanovi.AllowDrop = true;
            this.cbStanovi.DataSource = this.stanBindingSource;
            this.cbStanovi.DisplayMember = "Oznaka";
            this.cbStanovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStanovi.Enabled = false;
            this.cbStanovi.FormattingEnabled = true;
            this.cbStanovi.Location = new System.Drawing.Point(492, 117);
            this.cbStanovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStanovi.Name = "cbStanovi";
            this.cbStanovi.Size = new System.Drawing.Size(333, 29);
            this.cbStanovi.TabIndex = 3;
            this.cbStanovi.ValueMember = "ID";
            this.cbStanovi.SelectedIndexChanged += new System.EventHandler(this.cbStanovi_SelectedIndexChanged);
            // 
            // stanBindingSource
            // 
            this.stanBindingSource.DataMember = "Stan";
            this.stanBindingSource.DataSource = this.dB_18082;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Popis katova";
            // 
            // cbKatovi
            // 
            this.cbKatovi.AllowDrop = true;
            this.cbKatovi.DataSource = this.katBindingSource;
            this.cbKatovi.DisplayMember = "Oznaka";
            this.cbKatovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKatovi.Enabled = false;
            this.cbKatovi.FormattingEnabled = true;
            this.cbKatovi.Location = new System.Drawing.Point(361, 79);
            this.cbKatovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKatovi.Name = "cbKatovi";
            this.cbKatovi.Size = new System.Drawing.Size(348, 29);
            this.cbKatovi.TabIndex = 2;
            this.cbKatovi.ValueMember = "ID";
            this.cbKatovi.SelectedIndexChanged += new System.EventHandler(this.cbKatovi_SelectedIndexChanged);
            // 
            // katBindingSource
            // 
            this.katBindingSource.DataMember = "Kat";
            this.katBindingSource.DataSource = this.dB_18082;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Popis ulaza";
            // 
            // cbUlazi
            // 
            this.cbUlazi.AllowDrop = true;
            this.cbUlazi.DataSource = this.ulazBindingSource;
            this.cbUlazi.DisplayMember = "Oznaka";
            this.cbUlazi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUlazi.Enabled = false;
            this.cbUlazi.FormattingEnabled = true;
            this.cbUlazi.Location = new System.Drawing.Point(241, 43);
            this.cbUlazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUlazi.Name = "cbUlazi";
            this.cbUlazi.Size = new System.Drawing.Size(337, 29);
            this.cbUlazi.TabIndex = 1;
            this.cbUlazi.ValueMember = "ID";
            this.cbUlazi.SelectedIndexChanged += new System.EventHandler(this.cbUlazi_SelectedIndexChanged);
            // 
            // ulazBindingSource
            // 
            this.ulazBindingSource.DataMember = "Ulaz";
            this.ulazBindingSource.DataSource = this.dB_18082;
            // 
            // ZgradePopisLabel
            // 
            this.ZgradePopisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZgradePopisLabel.AutoSize = true;
            this.ZgradePopisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZgradePopisLabel.Location = new System.Drawing.Point(5, 10);
            this.ZgradePopisLabel.Name = "ZgradePopisLabel";
            this.ZgradePopisLabel.Size = new System.Drawing.Size(107, 20);
            this.ZgradePopisLabel.TabIndex = 61;
            this.ZgradePopisLabel.Text = "Popis zgrada";
            // 
            // dgvPopisTroskova
            // 
            this.dgvPopisTroskova.AllowUserToAddRows = false;
            this.dgvPopisTroskova.AllowUserToDeleteRows = false;
            this.dgvPopisTroskova.AllowUserToOrderColumns = true;
            this.dgvPopisTroskova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisTroskova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisTroskova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTroskova.Location = new System.Drawing.Point(9, 156);
            this.dgvPopisTroskova.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPopisTroskova.MultiSelect = false;
            this.dgvPopisTroskova.Name = "dgvPopisTroskova";
            this.dgvPopisTroskova.ReadOnly = true;
            this.dgvPopisTroskova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisTroskova.Size = new System.Drawing.Size(1403, 438);
            this.dgvPopisTroskova.TabIndex = 62;
            // 
            // cbZgrade
            // 
            this.cbZgrade.AllowDrop = true;
            this.cbZgrade.DataSource = this.zgradaBindingSource;
            this.cbZgrade.DisplayMember = "Lokacija";
            this.cbZgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZgrade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbZgrade.FormattingEnabled = true;
            this.cbZgrade.Location = new System.Drawing.Point(132, 5);
            this.cbZgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbZgrade.Name = "cbZgrade";
            this.cbZgrade.Size = new System.Drawing.Size(327, 29);
            this.cbZgrade.TabIndex = 0;
            this.cbZgrade.ValueMember = "ID";
            this.cbZgrade.SelectedIndexChanged += new System.EventHandler(this.cbZgrade_SelectedIndexChanged);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(1353, 12);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(91, 34);
            this.btnOdjava.TabIndex = 29;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zgradaTableAdapter
            // 
            this.zgradaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // ulazTableAdapter
            // 
            this.ulazTableAdapter.ClearBeforeFill = true;
            // 
            // katTableAdapter
            // 
            this.katTableAdapter.ClearBeforeFill = true;
            // 
            // stanTableAdapter
            // 
            this.stanTableAdapter.ClearBeforeFill = true;
            // 
            // zgradaTableAdapter1
            // 
            this.zgradaTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Zgrada";
            this.bindingSource1.DataSource = this.dB_18082;
            // 
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Location = new System.Drawing.Point(20, 12);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(0, 17);
            this.korisnickoImeLabel.TabIndex = 37;
            // 
            // zgradaBindingSource1
            // 
            this.zgradaBindingSource1.DataMember = "Zgrada";
            this.zgradaBindingSource1.DataSource = this.dB_18082;
            // 
            // prikaziDugovanjaButton
            // 
            this.prikaziDugovanjaButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.prikaziDugovanjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziDugovanjaButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.prikaziDugovanjaButton.ForeColor = System.Drawing.Color.White;
            this.prikaziDugovanjaButton.Location = new System.Drawing.Point(6, 177);
            this.prikaziDugovanjaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziDugovanjaButton.Name = "prikaziDugovanjaButton";
            this.prikaziDugovanjaButton.Size = new System.Drawing.Size(121, 61);
            this.prikaziDugovanjaButton.TabIndex = 47;
            this.prikaziDugovanjaButton.Text = "Prikaži dugovanja";
            this.prikaziDugovanjaButton.UseVisualStyleBackColor = false;
            this.prikaziDugovanjaButton.Click += new System.EventHandler(this.prikaziDugovanjaButton_Click);
            // 
            // placenoDugovanjeButton
            // 
            this.placenoDugovanjeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.placenoDugovanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placenoDugovanjeButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.placenoDugovanjeButton.ForeColor = System.Drawing.Color.White;
            this.placenoDugovanjeButton.Location = new System.Drawing.Point(7, 307);
            this.placenoDugovanjeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placenoDugovanjeButton.Name = "placenoDugovanjeButton";
            this.placenoDugovanjeButton.Size = new System.Drawing.Size(121, 55);
            this.placenoDugovanjeButton.TabIndex = 49;
            this.placenoDugovanjeButton.Text = "Plaćeno dugovanje";
            this.placenoDugovanjeButton.UseVisualStyleBackColor = false;
            this.placenoDugovanjeButton.Click += new System.EventHandler(this.placenoDugovanjeButton_Click);
            // 
            // noviMjesecButton
            // 
            this.noviMjesecButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.noviMjesecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noviMjesecButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.noviMjesecButton.ForeColor = System.Drawing.Color.White;
            this.noviMjesecButton.Location = new System.Drawing.Point(6, 242);
            this.noviMjesecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noviMjesecButton.Name = "noviMjesecButton";
            this.noviMjesecButton.Size = new System.Drawing.Size(121, 61);
            this.noviMjesecButton.TabIndex = 50;
            this.noviMjesecButton.Text = "Novi mjesec stanarina";
            this.noviMjesecButton.UseVisualStyleBackColor = false;
            this.noviMjesecButton.Click += new System.EventHandler(this.noviMjesecButton_Click);
            // 
            // posaljiUplatniceButton
            // 
            this.posaljiUplatniceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.posaljiUplatniceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posaljiUplatniceButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.posaljiUplatniceButton.ForeColor = System.Drawing.Color.White;
            this.posaljiUplatniceButton.Location = new System.Drawing.Point(8, 366);
            this.posaljiUplatniceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posaljiUplatniceButton.Name = "posaljiUplatniceButton";
            this.posaljiUplatniceButton.Size = new System.Drawing.Size(121, 55);
            this.posaljiUplatniceButton.TabIndex = 51;
            this.posaljiUplatniceButton.Text = "Pošalji uplatnice";
            this.posaljiUplatniceButton.UseVisualStyleBackColor = false;
            this.posaljiUplatniceButton.Click += new System.EventHandler(this.posaljiUplatniceButton_Click);
            // 
            // VlasnikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 694);
            this.Controls.Add(this.korisnickoImeLabel);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VlasnikaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentReady - Vlasnik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VlasnikaForma_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VlasnikaForma_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabZaposlenici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopisZaposlenikaGrid)).EndInit();
            this.tabZgrade.ResumeLayout(false);
            this.tabZgrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZgrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).EndInit();
            this.tabStanari.ResumeLayout(false);
            this.tabStanari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanariDataGrid)).EndInit();
            this.tabIzvještaji.ResumeLayout(false);
            this.tabIzvještaji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTroskova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZaposlenici;
        private System.Windows.Forms.TabPage tabZgrade;
        private System.Windows.Forms.TabPage tabStanari;
        private System.Windows.Forms.TabPage tabIzvještaji;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.DataGridView PopisZaposlenikaGrid;
        private System.Windows.Forms.Button btnKontaktirajZaposlenika;
        private System.Windows.Forms.Button btnBrisiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnAzurirajZaposlenika;
        private System.Windows.Forms.DataGridView stanariDataGrid;
        private System.Windows.Forms.Button kontaktirajStanaraButton;
        private System.Windows.Forms.Button brisiStanaraButton;
        private System.Windows.Forms.Button dodajStanaraButton;
        private System.Windows.Forms.Button azurirajStanareButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDodijeliPosao;
        private System.Windows.Forms.DataGridView dgvPopisZgrada;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private DB_18082 dB_18082;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource zgradaBindingSource;
        private System.Windows.Forms.Button btnBrisiZgradu;
        private System.Windows.Forms.Button btnDodajZgradu;
        private System.Windows.Forms.Button btnAzurirajZgradu;
        private System.Windows.Forms.BindingSource katBindingSource;
        private System.Windows.Forms.BindingSource stanBindingSource;
        private DB_18082TableAdapters.ZgradaTableAdapter zgradaTableAdapter;
        private DB_18082TableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private DB_18082TableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private DB_18082TableAdapters.UlazTableAdapter ulazTableAdapter;
        private DB_18082TableAdapters.KatTableAdapter katTableAdapter;
        private DB_18082TableAdapters.StanTableAdapter stanTableAdapter;
        private System.Windows.Forms.DataGridView dgvPopisTroskova;
        private System.Windows.Forms.Label ZgradePopisLabel;
        private System.Windows.Forms.ComboBox cbZgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUlazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKatovi;
        private System.Windows.Forms.Button btnIspisTroskovaUPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStanovi;
        private System.Windows.Forms.BindingSource ulazBindingSource;
        private DB_18082TableAdapters.ZgradaTableAdapter zgradaTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.BindingSource zgradaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vlasnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button prikaziSveStanareButton;
        private System.Windows.Forms.Button traziStanaraButton;
        private System.Windows.Forms.TextBox uvjetTrazenjaStanaraTextBox;
        private System.Windows.Forms.Button prikaziDugovanjaButton;
        private System.Windows.Forms.Button placenoDugovanjeButton;
        private System.Windows.Forms.Button noviMjesecButton;
        private System.Windows.Forms.Button posaljiUplatniceButton;
    }
}