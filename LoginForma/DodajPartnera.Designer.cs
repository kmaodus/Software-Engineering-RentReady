namespace LoginForma
{
    partial class DodajPartnera
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
            System.Windows.Forms.Label brojMobitelaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nazivLabel;
            this.dB_18082 = new LoginForma.DB_18082();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerTableAdapter = new LoginForma.DB_18082TableAdapters.PartnerTableAdapter();
            this.tableAdapterManager = new LoginForma.DB_18082TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajPartnera = new System.Windows.Forms.Button();
            this.txtBrojMobitelaPartnera = new System.Windows.Forms.TextBox();
            this.txtEmailPartnera = new System.Windows.Forms.TextBox();
            this.txtNazivPartnera = new System.Windows.Forms.TextBox();
            brojMobitelaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brojMobitelaLabel
            // 
            brojMobitelaLabel.AutoSize = true;
            brojMobitelaLabel.Location = new System.Drawing.Point(8, 91);
            brojMobitelaLabel.Name = "brojMobitelaLabel";
            brojMobitelaLabel.Size = new System.Drawing.Size(71, 13);
            brojMobitelaLabel.TabIndex = 12;
            brojMobitelaLabel.Text = "Broj Mobitela:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(44, 65);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(42, 39);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 8;
            nazivLabel.Text = "Naziv:";
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "Partner";
            this.partnerBindingSource.DataSource = this.dB_18082;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KatTableAdapter = null;
            this.tableAdapterManager.MogucPosaoTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = this.partnerTableAdapter;
            this.tableAdapterManager.StanarTableAdapter = null;
            this.tableAdapterManager.StanTableAdapter = null;
            this.tableAdapterManager.UgovorenPosaoTableAdapter = null;
            this.tableAdapterManager.UlazTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LoginForma.DB_18082TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UplatnicaTableAdapter = null;
            this.tableAdapterManager.VlasnikTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            this.tableAdapterManager.ZgradaTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dodaj partnera";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdustani.Location = new System.Drawing.Point(78, 125);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajPartnera
            // 
            this.btnDodajPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajPartnera.Location = new System.Drawing.Point(159, 125);
            this.btnDodajPartnera.Name = "btnDodajPartnera";
            this.btnDodajPartnera.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPartnera.TabIndex = 3;
            this.btnDodajPartnera.Text = "Dodaj";
            this.btnDodajPartnera.UseVisualStyleBackColor = true;
            this.btnDodajPartnera.Click += new System.EventHandler(this.btnDodajPartnera_Click);
            // 
            // txtBrojMobitelaPartnera
            // 
            this.txtBrojMobitelaPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrojMobitelaPartnera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "BrojMobitela", true));
            this.txtBrojMobitelaPartnera.Location = new System.Drawing.Point(85, 88);
            this.txtBrojMobitelaPartnera.Name = "txtBrojMobitelaPartnera";
            this.txtBrojMobitelaPartnera.Size = new System.Drawing.Size(149, 20);
            this.txtBrojMobitelaPartnera.TabIndex = 2;
            // 
            // txtEmailPartnera
            // 
            this.txtEmailPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailPartnera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Email", true));
            this.txtEmailPartnera.Location = new System.Drawing.Point(85, 62);
            this.txtEmailPartnera.Name = "txtEmailPartnera";
            this.txtEmailPartnera.Size = new System.Drawing.Size(149, 20);
            this.txtEmailPartnera.TabIndex = 1;
            // 
            // txtNazivPartnera
            // 
            this.txtNazivPartnera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivPartnera.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Naziv", true));
            this.txtNazivPartnera.Location = new System.Drawing.Point(85, 36);
            this.txtNazivPartnera.Name = "txtNazivPartnera";
            this.txtNazivPartnera.Size = new System.Drawing.Size(149, 20);
            this.txtNazivPartnera.TabIndex = 0;
            // 
            // DodajPartnera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 166);
            this.Controls.Add(brojMobitelaLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajPartnera);
            this.Controls.Add(this.txtBrojMobitelaPartnera);
            this.Controls.Add(this.txtEmailPartnera);
            this.Controls.Add(this.txtNazivPartnera);
            this.Name = "DodajPartnera";
            this.Text = "Dodaj partnera";
            this.Load += new System.EventHandler(this.DodajPartnera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_18082 dB_18082;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private DB_18082TableAdapters.PartnerTableAdapter partnerTableAdapter;
        private DB_18082TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajPartnera;
        private System.Windows.Forms.TextBox txtBrojMobitelaPartnera;
        private System.Windows.Forms.TextBox txtEmailPartnera;
        private System.Windows.Forms.TextBox txtNazivPartnera;
    }
}