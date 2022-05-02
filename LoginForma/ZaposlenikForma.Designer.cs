namespace LoginForma
{
    partial class ZaposlenikForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposlenikForma));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZaposlenici = new System.Windows.Forms.TabPage();
            this.PopisZaposlenikaGrid = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.tabZgrade = new System.Windows.Forms.TabPage();
            this.txtDodijeliPosaoZaposlenik = new System.Windows.Forms.Button();
            this.dgvPopisZgrada = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlasnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_18082 = new LoginForma.DB_18082();
            this.zaposlenikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zgradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStanari = new System.Windows.Forms.TabPage();
            this.prikaziDugovanjaButton = new System.Windows.Forms.Button();
            this.prikaziSveStanareButton = new System.Windows.Forms.Button();
            this.traziStanaraButton = new System.Windows.Forms.Button();
            this.uvjetTrazenjaStanaraTextBox = new System.Windows.Forms.TextBox();
            this.stanariDataGrid = new System.Windows.Forms.DataGridView();
            this.kontaktirajStanaraButton = new System.Windows.Forms.Button();
            this.brisiStanaraButton = new System.Windows.Forms.Button();
            this.dodajStanaraButton = new System.Windows.Forms.Button();
            this.azurirajStanaraButton = new System.Windows.Forms.Button();
            this.tabIzvještaji = new System.Windows.Forms.TabPage();
            this.dgvPopisTroskova = new System.Windows.Forms.DataGridView();
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
            this.cbZgrade = new System.Windows.Forms.ComboBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.zgradaTableAdapter = new LoginForma.DB_18082TableAdapters.ZgradaTableAdapter();
            this.vlasnikTableAdapter = new LoginForma.DB_18082TableAdapters.VlasnikTableAdapter();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new LoginForma.DB_18082TableAdapters.ZaposlenikTableAdapter();
            this.zgradaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ulazTableAdapter = new LoginForma.DB_18082TableAdapters.UlazTableAdapter();
            this.katTableAdapter = new LoginForma.DB_18082TableAdapters.KatTableAdapter();
            this.stanTableAdapter = new LoginForma.DB_18082TableAdapters.StanTableAdapter();
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.noviMjesecButton = new System.Windows.Forms.Button();
            this.placenoDugovanjeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabZaposlenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopisZaposlenikaGrid)).BeginInit();
            this.tabZgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZgrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).BeginInit();
            this.tabStanari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanariDataGrid)).BeginInit();
            this.tabIzvještaji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTroskova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1379, -39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 34);
            this.button1.TabIndex = 33;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1436, -39);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 34);
            this.button3.TabIndex = 32;
            this.button3.Text = "Odjava";
            this.button3.UseVisualStyleBackColor = false;
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
            this.tabControl1.Size = new System.Drawing.Size(1455, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabZaposlenici
            // 
            this.tabZaposlenici.Controls.Add(this.PopisZaposlenikaGrid);
            this.tabZaposlenici.Controls.Add(this.button6);
            this.tabZaposlenici.Location = new System.Drawing.Point(4, 30);
            this.tabZaposlenici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZaposlenici.Name = "tabZaposlenici";
            this.tabZaposlenici.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZaposlenici.Size = new System.Drawing.Size(1447, 538);
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
            this.PopisZaposlenikaGrid.Location = new System.Drawing.Point(132, 5);
            this.PopisZaposlenikaGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopisZaposlenikaGrid.Name = "PopisZaposlenikaGrid";
            this.PopisZaposlenikaGrid.RowTemplate.Height = 24;
            this.PopisZaposlenikaGrid.Size = new System.Drawing.Size(1157, 523);
            this.PopisZaposlenikaGrid.TabIndex = 41;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(5, 478);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 50);
            this.button6.TabIndex = 40;
            this.button6.Text = "Kontaktiraj";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tabZgrade
            // 
            this.tabZgrade.Controls.Add(this.txtDodijeliPosaoZaposlenik);
            this.tabZgrade.Controls.Add(this.dgvPopisZgrada);
            this.tabZgrade.Location = new System.Drawing.Point(4, 30);
            this.tabZgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZgrade.Name = "tabZgrade";
            this.tabZgrade.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabZgrade.Size = new System.Drawing.Size(1447, 538);
            this.tabZgrade.TabIndex = 1;
            this.tabZgrade.Text = "Zgrade";
            this.tabZgrade.UseVisualStyleBackColor = true;
            // 
            // txtDodijeliPosaoZaposlenik
            // 
            this.txtDodijeliPosaoZaposlenik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDodijeliPosaoZaposlenik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.txtDodijeliPosaoZaposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDodijeliPosaoZaposlenik.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.txtDodijeliPosaoZaposlenik.ForeColor = System.Drawing.Color.White;
            this.txtDodijeliPosaoZaposlenik.Location = new System.Drawing.Point(5, 465);
            this.txtDodijeliPosaoZaposlenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDodijeliPosaoZaposlenik.Name = "txtDodijeliPosaoZaposlenik";
            this.txtDodijeliPosaoZaposlenik.Size = new System.Drawing.Size(121, 63);
            this.txtDodijeliPosaoZaposlenik.TabIndex = 1;
            this.txtDodijeliPosaoZaposlenik.Text = "Dodijeli posao";
            this.txtDodijeliPosaoZaposlenik.UseVisualStyleBackColor = false;
            this.txtDodijeliPosaoZaposlenik.Click += new System.EventHandler(this.txtDodijeliPosaoZaposlenik_Click);
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
            this.iDDataGridViewTextBoxColumn,
            this.vlasnikIDDataGridViewTextBoxColumn,
            this.zaposlenikIDDataGridViewTextBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn});
            this.dgvPopisZgrada.DataSource = this.zgradaBindingSource;
            this.dgvPopisZgrada.Location = new System.Drawing.Point(132, 5);
            this.dgvPopisZgrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPopisZgrada.MultiSelect = false;
            this.dgvPopisZgrada.Name = "dgvPopisZgrada";
            this.dgvPopisZgrada.ReadOnly = true;
            this.dgvPopisZgrada.RowTemplate.Height = 24;
            this.dgvPopisZgrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZgrada.Size = new System.Drawing.Size(1157, 523);
            this.dgvPopisZgrada.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vlasnikIDDataGridViewTextBoxColumn
            // 
            this.vlasnikIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vlasnikIDDataGridViewTextBoxColumn.DataPropertyName = "VlasnikID";
            this.vlasnikIDDataGridViewTextBoxColumn.DataSource = this.vlasnikBindingSource;
            this.vlasnikIDDataGridViewTextBoxColumn.DisplayMember = "Prezime";
            this.vlasnikIDDataGridViewTextBoxColumn.HeaderText = "Prezime vlasnika";
            this.vlasnikIDDataGridViewTextBoxColumn.Name = "vlasnikIDDataGridViewTextBoxColumn";
            this.vlasnikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlasnikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vlasnikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vlasnikIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "Vlasnik";
            this.vlasnikBindingSource.DataSource = this.dB_18082;
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenikIDDataGridViewTextBoxColumn
            // 
            this.zaposlenikIDDataGridViewTextBoxColumn.DataPropertyName = "ZaposlenikID";
            this.zaposlenikIDDataGridViewTextBoxColumn.HeaderText = "ZaposlenikID";
            this.zaposlenikIDDataGridViewTextBoxColumn.Name = "zaposlenikIDDataGridViewTextBoxColumn";
            this.zaposlenikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            this.lokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zgradaBindingSource
            // 
            this.zgradaBindingSource.DataMember = "Zgrada";
            this.zgradaBindingSource.DataSource = this.dB_18082;
            // 
            // tabStanari
            // 
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
            this.tabStanari.Controls.Add(this.azurirajStanaraButton);
            this.tabStanari.Location = new System.Drawing.Point(4, 30);
            this.tabStanari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStanari.Name = "tabStanari";
            this.tabStanari.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStanari.Size = new System.Drawing.Size(1447, 538);
            this.tabStanari.TabIndex = 2;
            this.tabStanari.Text = "Stanari";
            this.tabStanari.UseVisualStyleBackColor = true;
            // 
            // prikaziDugovanjaButton
            // 
            this.prikaziDugovanjaButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.prikaziDugovanjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziDugovanjaButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.prikaziDugovanjaButton.ForeColor = System.Drawing.Color.White;
            this.prikaziDugovanjaButton.Location = new System.Drawing.Point(6, 148);
            this.prikaziDugovanjaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziDugovanjaButton.Name = "prikaziDugovanjaButton";
            this.prikaziDugovanjaButton.Size = new System.Drawing.Size(121, 50);
            this.prikaziDugovanjaButton.TabIndex = 46;
            this.prikaziDugovanjaButton.Text = "Prikaži dugovanja";
            this.prikaziDugovanjaButton.UseVisualStyleBackColor = false;
            this.prikaziDugovanjaButton.Click += new System.EventHandler(this.prikaziDugovanjaButton_Click);
            // 
            // prikaziSveStanareButton
            // 
            this.prikaziSveStanareButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.prikaziSveStanareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziSveStanareButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.prikaziSveStanareButton.ForeColor = System.Drawing.Color.White;
            this.prikaziSveStanareButton.Location = new System.Drawing.Point(6, 94);
            this.prikaziSveStanareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziSveStanareButton.Name = "prikaziSveStanareButton";
            this.prikaziSveStanareButton.Size = new System.Drawing.Size(121, 50);
            this.prikaziSveStanareButton.TabIndex = 45;
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
            this.traziStanaraButton.Location = new System.Drawing.Point(6, 40);
            this.traziStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.traziStanaraButton.Name = "traziStanaraButton";
            this.traziStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.traziStanaraButton.TabIndex = 44;
            this.traziStanaraButton.Text = "Traži";
            this.traziStanaraButton.UseVisualStyleBackColor = false;
            this.traziStanaraButton.Click += new System.EventHandler(this.traziStanaraButton_Click);
            // 
            // uvjetTrazenjaStanaraTextBox
            // 
            this.uvjetTrazenjaStanaraTextBox.Location = new System.Drawing.Point(5, 5);
            this.uvjetTrazenjaStanaraTextBox.Name = "uvjetTrazenjaStanaraTextBox";
            this.uvjetTrazenjaStanaraTextBox.Size = new System.Drawing.Size(120, 30);
            this.uvjetTrazenjaStanaraTextBox.TabIndex = 43;
            // 
            // stanariDataGrid
            // 
            this.stanariDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stanariDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stanariDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stanariDataGrid.Location = new System.Drawing.Point(132, 5);
            this.stanariDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stanariDataGrid.Name = "stanariDataGrid";
            this.stanariDataGrid.RowTemplate.Height = 24;
            this.stanariDataGrid.Size = new System.Drawing.Size(1157, 523);
            this.stanariDataGrid.TabIndex = 41;
            // 
            // kontaktirajStanaraButton
            // 
            this.kontaktirajStanaraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kontaktirajStanaraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.kontaktirajStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kontaktirajStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.kontaktirajStanaraButton.ForeColor = System.Drawing.Color.White;
            this.kontaktirajStanaraButton.Location = new System.Drawing.Point(5, 478);
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
            this.brisiStanaraButton.Location = new System.Drawing.Point(5, 422);
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
            this.dodajStanaraButton.Location = new System.Drawing.Point(5, 367);
            this.dodajStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajStanaraButton.Name = "dodajStanaraButton";
            this.dodajStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.dodajStanaraButton.TabIndex = 38;
            this.dodajStanaraButton.Text = "Dodaj";
            this.dodajStanaraButton.UseVisualStyleBackColor = false;
            this.dodajStanaraButton.Click += new System.EventHandler(this.dodajStanaraButton_Click);
            // 
            // azurirajStanaraButton
            // 
            this.azurirajStanaraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.azurirajStanaraButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.azurirajStanaraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azurirajStanaraButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.azurirajStanaraButton.ForeColor = System.Drawing.Color.White;
            this.azurirajStanaraButton.Location = new System.Drawing.Point(5, 311);
            this.azurirajStanaraButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajStanaraButton.Name = "azurirajStanaraButton";
            this.azurirajStanaraButton.Size = new System.Drawing.Size(121, 50);
            this.azurirajStanaraButton.TabIndex = 37;
            this.azurirajStanaraButton.Text = "Ažuriraj";
            this.azurirajStanaraButton.UseVisualStyleBackColor = false;
            this.azurirajStanaraButton.Click += new System.EventHandler(this.azurirajStanaraButton_Click);
            // 
            // tabIzvještaji
            // 
            this.tabIzvještaji.Controls.Add(this.dgvPopisTroskova);
            this.tabIzvještaji.Controls.Add(this.btnIspisTroskovaUPDF);
            this.tabIzvještaji.Controls.Add(this.label3);
            this.tabIzvještaji.Controls.Add(this.cbStanovi);
            this.tabIzvještaji.Controls.Add(this.label2);
            this.tabIzvještaji.Controls.Add(this.cbKatovi);
            this.tabIzvještaji.Controls.Add(this.label1);
            this.tabIzvještaji.Controls.Add(this.cbUlazi);
            this.tabIzvještaji.Controls.Add(this.ZgradePopisLabel);
            this.tabIzvještaji.Controls.Add(this.cbZgrade);
            this.tabIzvještaji.Location = new System.Drawing.Point(4, 30);
            this.tabIzvještaji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIzvještaji.Name = "tabIzvještaji";
            this.tabIzvještaji.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIzvještaji.Size = new System.Drawing.Size(1447, 538);
            this.tabIzvještaji.TabIndex = 3;
            this.tabIzvještaji.Text = "Izvještaji";
            this.tabIzvještaji.UseVisualStyleBackColor = true;
            // 
            // dgvPopisTroskova
            // 
            this.dgvPopisTroskova.AllowUserToAddRows = false;
            this.dgvPopisTroskova.AllowUserToDeleteRows = false;
            this.dgvPopisTroskova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisTroskova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisTroskova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTroskova.Location = new System.Drawing.Point(11, 159);
            this.dgvPopisTroskova.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPopisTroskova.MultiSelect = false;
            this.dgvPopisTroskova.Name = "dgvPopisTroskova";
            this.dgvPopisTroskova.ReadOnly = true;
            this.dgvPopisTroskova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisTroskova.Size = new System.Drawing.Size(1427, 368);
            this.dgvPopisTroskova.TabIndex = 71;
            // 
            // btnIspisTroskovaUPDF
            // 
            this.btnIspisTroskovaUPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIspisTroskovaUPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIspisTroskovaUPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnIspisTroskovaUPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspisTroskovaUPDF.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnIspisTroskovaUPDF.ForeColor = System.Drawing.Color.White;
            this.btnIspisTroskovaUPDF.Location = new System.Drawing.Point(1197, 5);
            this.btnIspisTroskovaUPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIspisTroskovaUPDF.Name = "btnIspisTroskovaUPDF";
            this.btnIspisTroskovaUPDF.Size = new System.Drawing.Size(241, 145);
            this.btnIspisTroskovaUPDF.TabIndex = 70;
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
            this.label3.Location = new System.Drawing.Point(359, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 69;
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
            this.cbStanovi.Location = new System.Drawing.Point(493, 119);
            this.cbStanovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStanovi.Name = "cbStanovi";
            this.cbStanovi.Size = new System.Drawing.Size(332, 29);
            this.cbStanovi.TabIndex = 68;
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
            this.label2.Location = new System.Drawing.Point(236, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 67;
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
            this.cbKatovi.Location = new System.Drawing.Point(360, 81);
            this.cbKatovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKatovi.Name = "cbKatovi";
            this.cbKatovi.Size = new System.Drawing.Size(351, 29);
            this.cbKatovi.TabIndex = 66;
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
            this.label1.Location = new System.Drawing.Point(127, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 65;
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
            this.cbUlazi.Location = new System.Drawing.Point(240, 43);
            this.cbUlazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUlazi.Name = "cbUlazi";
            this.cbUlazi.Size = new System.Drawing.Size(337, 29);
            this.cbUlazi.TabIndex = 64;
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
            this.ZgradePopisLabel.Location = new System.Drawing.Point(7, 10);
            this.ZgradePopisLabel.Name = "ZgradePopisLabel";
            this.ZgradePopisLabel.Size = new System.Drawing.Size(107, 20);
            this.ZgradePopisLabel.TabIndex = 63;
            this.ZgradePopisLabel.Text = "Popis zgrada";
            // 
            // cbZgrade
            // 
            this.cbZgrade.AllowDrop = true;
            this.cbZgrade.DataSource = this.zgradaBindingSource;
            this.cbZgrade.DisplayMember = "Lokacija";
            this.cbZgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZgrade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbZgrade.FormattingEnabled = true;
            this.cbZgrade.Location = new System.Drawing.Point(133, 5);
            this.cbZgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbZgrade.Name = "cbZgrade";
            this.cbZgrade.Size = new System.Drawing.Size(324, 29);
            this.cbZgrade.TabIndex = 62;
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
            this.btnOdjava.Location = new System.Drawing.Point(1379, 12);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(91, 34);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // zgradaTableAdapter
            // 
            this.zgradaTableAdapter.ClearBeforeFill = true;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.dB_18082;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // zgradaBindingSource1
            // 
            this.zgradaBindingSource1.DataMember = "Zgrada";
            this.zgradaBindingSource1.DataSource = this.dB_18082;
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
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Location = new System.Drawing.Point(20, 12);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(0, 17);
            this.korisnickoImeLabel.TabIndex = 36;
            // 
            // noviMjesecButton
            // 
            this.noviMjesecButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.noviMjesecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noviMjesecButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.noviMjesecButton.ForeColor = System.Drawing.Color.White;
            this.noviMjesecButton.Location = new System.Drawing.Point(6, 202);
            this.noviMjesecButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noviMjesecButton.Name = "noviMjesecButton";
            this.noviMjesecButton.Size = new System.Drawing.Size(121, 61);
            this.noviMjesecButton.TabIndex = 52;
            this.noviMjesecButton.Text = "Novi mjesec stanarina";
            this.noviMjesecButton.UseVisualStyleBackColor = false;
            this.noviMjesecButton.Click += new System.EventHandler(this.noviMjesecButton_Click);
            // 
            // placenoDugovanjeButton
            // 
            this.placenoDugovanjeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.placenoDugovanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placenoDugovanjeButton.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.placenoDugovanjeButton.ForeColor = System.Drawing.Color.White;
            this.placenoDugovanjeButton.Location = new System.Drawing.Point(7, 267);
            this.placenoDugovanjeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placenoDugovanjeButton.Name = "placenoDugovanjeButton";
            this.placenoDugovanjeButton.Size = new System.Drawing.Size(121, 55);
            this.placenoDugovanjeButton.TabIndex = 51;
            this.placenoDugovanjeButton.Text = "Plaćeno dugovanje";
            this.placenoDugovanjeButton.UseVisualStyleBackColor = false;
            this.placenoDugovanjeButton.Click += new System.EventHandler(this.placenoDugovanjeButton_Click);
            // 
            // ZaposlenikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 626);
            this.Controls.Add(this.korisnickoImeLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ZaposlenikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentReady - Zaposlenici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ZaposlenikForma_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZaposlenikForma_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabZaposlenici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopisZaposlenikaGrid)).EndInit();
            this.tabZgrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZgrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).EndInit();
            this.tabStanari.ResumeLayout(false);
            this.tabStanari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stanariDataGrid)).EndInit();
            this.tabIzvještaji.ResumeLayout(false);
            this.tabIzvještaji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTroskova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZaposlenici;
        private System.Windows.Forms.DataGridView PopisZaposlenikaGrid;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabStanari;
        private System.Windows.Forms.DataGridView stanariDataGrid;
        private System.Windows.Forms.Button kontaktirajStanaraButton;
        private System.Windows.Forms.Button brisiStanaraButton;
        private System.Windows.Forms.Button dodajStanaraButton;
        private System.Windows.Forms.Button azurirajStanaraButton;
        private System.Windows.Forms.TabPage tabIzvještaji;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.TabPage tabZgrade;
        private DB_18082 dB_18082;
        private System.Windows.Forms.BindingSource zgradaBindingSource;
        private DB_18082TableAdapters.ZgradaTableAdapter zgradaTableAdapter;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private DB_18082TableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private DB_18082TableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridView dgvPopisZgrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vlasnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button txtDodijeliPosaoZaposlenik;
        private System.Windows.Forms.BindingSource ulazBindingSource;
        private System.Windows.Forms.BindingSource katBindingSource;
        private System.Windows.Forms.BindingSource stanBindingSource;
        private System.Windows.Forms.BindingSource zgradaBindingSource1;
        private DB_18082TableAdapters.UlazTableAdapter ulazTableAdapter;
        private DB_18082TableAdapters.KatTableAdapter katTableAdapter;
        private DB_18082TableAdapters.StanTableAdapter stanTableAdapter;
        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.Label ZgradePopisLabel;
        private System.Windows.Forms.ComboBox cbZgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUlazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKatovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStanovi;
        private System.Windows.Forms.Button btnIspisTroskovaUPDF;
        private System.Windows.Forms.DataGridView dgvPopisTroskova;
        private System.Windows.Forms.Button prikaziSveStanareButton;
        private System.Windows.Forms.Button traziStanaraButton;
        private System.Windows.Forms.TextBox uvjetTrazenjaStanaraTextBox;
        private System.Windows.Forms.Button prikaziDugovanjaButton;
        private System.Windows.Forms.Button noviMjesecButton;
        private System.Windows.Forms.Button placenoDugovanjeButton;
    }
}