namespace LoginForma
{
    partial class DodajPosao
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
            System.Windows.Forms.Label opisLabel1;
            System.Windows.Forms.Label nazivLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajPosao = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dB_18082 = new LoginForma.DB_18082();
            this.mogucPosaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mogucPosaoTableAdapter = new LoginForma.DB_18082TableAdapters.MogucPosaoTableAdapter();
            this.tableAdapterManager = new LoginForma.DB_18082TableAdapters.TableAdapterManager();
            this.txtOpisPosla = new System.Windows.Forms.TextBox();
            this.txtNazivPosla = new System.Windows.Forms.TextBox();
            opisLabel1 = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // opisLabel1
            // 
            opisLabel1.AutoSize = true;
            opisLabel1.Location = new System.Drawing.Point(43, 91);
            opisLabel1.Name = "opisLabel1";
            opisLabel1.Size = new System.Drawing.Size(31, 13);
            opisLabel1.TabIndex = 12;
            opisLabel1.Text = "Opis:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(37, 65);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 13;
            nazivLabel.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dodaj posao";
            // 
            // btnDodajPosao
            // 
            this.btnDodajPosao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajPosao.Location = new System.Drawing.Point(173, 211);
            this.btnDodajPosao.Name = "btnDodajPosao";
            this.btnDodajPosao.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPosao.TabIndex = 2;
            this.btnDodajPosao.Text = "Dodaj";
            this.btnDodajPosao.UseVisualStyleBackColor = true;
            this.btnDodajPosao.Click += new System.EventHandler(this.btnDodajPosao_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdustani.Location = new System.Drawing.Point(92, 211);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dB_18082
            // 
            this.dB_18082.DataSetName = "DB_18082";
            this.dB_18082.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KatTableAdapter = null;
            this.tableAdapterManager.MogucPosaoTableAdapter = this.mogucPosaoTableAdapter;
            this.tableAdapterManager.PartnerTableAdapter = null;
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
            // txtOpisPosla
            // 
            this.txtOpisPosla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpisPosla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mogucPosaoBindingSource, "Opis", true));
            this.txtOpisPosla.Location = new System.Drawing.Point(80, 88);
            this.txtOpisPosla.Multiline = true;
            this.txtOpisPosla.Name = "txtOpisPosla";
            this.txtOpisPosla.Size = new System.Drawing.Size(168, 100);
            this.txtOpisPosla.TabIndex = 1;
            // 
            // txtNazivPosla
            // 
            this.txtNazivPosla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivPosla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mogucPosaoBindingSource, "Naziv", true));
            this.txtNazivPosla.Location = new System.Drawing.Point(80, 62);
            this.txtNazivPosla.Name = "txtNazivPosla";
            this.txtNazivPosla.Size = new System.Drawing.Size(168, 20);
            this.txtNazivPosla.TabIndex = 0;
            // 
            // DodajPosao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNazivPosla);
            this.Controls.Add(opisLabel1);
            this.Controls.Add(this.txtOpisPosla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajPosao);
            this.Controls.Add(this.btnOdustani);
            this.Name = "DodajPosao";
            this.Text = "Dodaj posao";
            this.Load += new System.EventHandler(this.DodajPosao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_18082)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogucPosaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPosao;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource mogucPosaoBindingSource;
        private DB_18082 dB_18082;
        private DB_18082TableAdapters.MogucPosaoTableAdapter mogucPosaoTableAdapter;
        private DB_18082TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtOpisPosla;
        private System.Windows.Forms.TextBox txtNazivPosla;
    }
}