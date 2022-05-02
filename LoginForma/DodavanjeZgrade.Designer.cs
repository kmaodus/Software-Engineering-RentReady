namespace LoginForma
{
    partial class DodavanjeZgrade
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
            System.Windows.Forms.Label lokacijaLabel;
            System.Windows.Forms.Label zaposlenikIDLabel1;
            this.dB_18082 = new LoginForma.DB_18082();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zgradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zgradaTableAdapter = new LoginForma.DB_18082TableAdapters.ZgradaTableAdapter();
            this.tableAdapterManager1 = new LoginForma.DB_18082TableAdapters.TableAdapterManager();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new LoginForma.DB_18082TableAdapters.ZaposlenikTableAdapter();
            lokacijaLabel = new System.Windows.Forms.Label();
            zaposlenikIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lokacijaLabel
            // 
            lokacijaLabel.AutoSize = true;
            lokacijaLabel.Location = new System.Drawing.Point(33, 90);
            lokacijaLabel.Name = "lokacijaLabel";
            lokacijaLabel.Size = new System.Drawing.Size(50, 13);
            lokacijaLabel.TabIndex = 14;
            lokacijaLabel.Text = "Lokacija:";
            // 
            // zaposlenikIDLabel1
            // 
            zaposlenikIDLabel1.AutoSize = true;
            zaposlenikIDLabel1.Location = new System.Drawing.Point(21, 63);
            zaposlenikIDLabel1.Name = "zaposlenikIDLabel1";
            zaposlenikIDLabel1.Size = new System.Drawing.Size(62, 13);
            zaposlenikIDLabel1.TabIndex = 13;
            zaposlenikIDLabel1.Text = "Zaposlenik:";
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(150, 132);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdustani.Location = new System.Drawing.Point(69, 132);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dodajte zgradu!";
            // 
            // zgradaBindingSource
            // 
            this.zgradaBindingSource.DataMember = "Zgrada";
            this.zgradaBindingSource.DataSource = this.dB_18082;
            // 
            // zgradaTableAdapter
            // 
            this.zgradaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.KatTableAdapter = null;
            this.tableAdapterManager1.MogucPosaoTableAdapter = null;
            this.tableAdapterManager1.PartnerTableAdapter = null;
            this.tableAdapterManager1.StanarTableAdapter = null;
            this.tableAdapterManager1.StanTableAdapter = null;
            this.tableAdapterManager1.UgovorenPosaoTableAdapter = null;
            this.tableAdapterManager1.UlazTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LoginForma.DB_18082TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UplatnicaTableAdapter = null;
            this.tableAdapterManager1.VlasnikTableAdapter = null;
            this.tableAdapterManager1.ZaposlenikTableAdapter = null;
            this.tableAdapterManager1.ZgradaTableAdapter = this.zgradaTableAdapter;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLokacija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zgradaBindingSource, "Lokacija", true));
            this.txtLokacija.Location = new System.Drawing.Point(89, 87);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(121, 20);
            this.txtLokacija.TabIndex = 1;
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zgradaBindingSource, "ZaposlenikID", true));
            this.cbZaposlenik.DataSource = this.zaposlenikBindingSource;
            this.cbZaposlenik.DisplayMember = "Prezime";
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(89, 60);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.cbZaposlenik.TabIndex = 0;
            this.cbZaposlenik.ValueMember = "ID";
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
            // DodavanjeZgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 177);
            this.Controls.Add(lokacijaLabel);
            this.Controls.Add(zaposlenikIDLabel1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.cbZaposlenik);
            this.Name = "DodavanjeZgrade";
            this.Text = "Dodavanje zgrade";
            this.Load += new System.EventHandler(this.DodavanjeZgrade_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DodavanjeZgrade_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_18082 dB_18082;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource zgradaBindingSource;
        private DB_18082TableAdapters.ZgradaTableAdapter zgradaTableAdapter;
        private DB_18082TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private DB_18082TableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
    }
}