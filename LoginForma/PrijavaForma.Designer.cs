namespace LoginForma
{
    partial class PrijavaForma
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForma));
            this.bunifuPrijavaKorIme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPrijavaLozinka = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelPrijava = new System.Windows.Forms.Panel();
            this.lozinkaJePoslanaLabel = new System.Windows.Forms.Label();
            this.prijavaPovratakButton = new System.Windows.Forms.Button();
            this.posaljiLozinkuButton = new System.Windows.Forms.Button();
            this.zaboravljenaLozinkaPorukaLabel = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnZaboravljenaLozinka = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPrebaciNaRegistraciju = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblPrijavaExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.panelRegistracija = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPrijavaKorIme
            // 
            this.bunifuPrijavaKorIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuPrijavaKorIme, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPrijavaKorIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuPrijavaKorIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuPrijavaKorIme.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuPrijavaKorIme.HintText = "Ime i Prezime";
            this.bunifuPrijavaKorIme.isPassword = false;
            this.bunifuPrijavaKorIme.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuPrijavaKorIme.LineIdleColor = System.Drawing.Color.White;
            this.bunifuPrijavaKorIme.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuPrijavaKorIme.LineThickness = 3;
            this.bunifuPrijavaKorIme.Location = new System.Drawing.Point(339, 163);
            this.bunifuPrijavaKorIme.Name = "bunifuPrijavaKorIme";
            this.bunifuPrijavaKorIme.Size = new System.Drawing.Size(284, 27);
            this.bunifuPrijavaKorIme.TabIndex = 0;
            this.bunifuPrijavaKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuPrijavaLozinka
            // 
            this.bunifuPrijavaLozinka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuPrijavaLozinka, BunifuAnimatorNS.DecorationType.None);
            this.bunifuPrijavaLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuPrijavaLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuPrijavaLozinka.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuPrijavaLozinka.HintText = "Unesite lozinku";
            this.bunifuPrijavaLozinka.isPassword = true;
            this.bunifuPrijavaLozinka.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuPrijavaLozinka.LineIdleColor = System.Drawing.Color.White;
            this.bunifuPrijavaLozinka.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuPrijavaLozinka.LineThickness = 3;
            this.bunifuPrijavaLozinka.Location = new System.Drawing.Point(339, 247);
            this.bunifuPrijavaLozinka.Name = "bunifuPrijavaLozinka";
            this.bunifuPrijavaLozinka.Size = new System.Drawing.Size(284, 27);
            this.bunifuPrijavaLozinka.TabIndex = 1;
            this.bunifuPrijavaLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(335, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lozinka:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(335, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Korisničko ime:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(334, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "Prijava";
            // 
            // panelPrijava
            // 
            this.panelPrijava.Controls.Add(this.lozinkaJePoslanaLabel);
            this.panelPrijava.Controls.Add(this.prijavaPovratakButton);
            this.panelPrijava.Controls.Add(this.posaljiLozinkuButton);
            this.panelPrijava.Controls.Add(this.zaboravljenaLozinkaPorukaLabel);
            this.panelPrijava.Controls.Add(this.btnPrijava);
            this.panelPrijava.Controls.Add(this.btnZaboravljenaLozinka);
            this.bunifuTransition1.SetDecoration(this.panelPrijava, BunifuAnimatorNS.DecorationType.None);
            this.panelPrijava.Location = new System.Drawing.Point(338, 42);
            this.panelPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPrijava.Name = "panelPrijava";
            this.panelPrijava.Size = new System.Drawing.Size(286, 518);
            this.panelPrijava.TabIndex = 26;
            // 
            // lozinkaJePoslanaLabel
            // 
            this.lozinkaJePoslanaLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lozinkaJePoslanaLabel, BunifuAnimatorNS.DecorationType.None);
            this.lozinkaJePoslanaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaJePoslanaLabel.ForeColor = System.Drawing.Color.White;
            this.lozinkaJePoslanaLabel.Location = new System.Drawing.Point(2, 378);
            this.lozinkaJePoslanaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lozinkaJePoslanaLabel.Name = "lozinkaJePoslanaLabel";
            this.lozinkaJePoslanaLabel.Size = new System.Drawing.Size(219, 21);
            this.lozinkaJePoslanaLabel.TabIndex = 27;
            this.lozinkaJePoslanaLabel.Text = "Lozinka je uspješno poslana";
            this.lozinkaJePoslanaLabel.Visible = false;
            // 
            // prijavaPovratakButton
            // 
            this.prijavaPovratakButton.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.prijavaPovratakButton, BunifuAnimatorNS.DecorationType.None);
            this.prijavaPovratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaPovratakButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.prijavaPovratakButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.prijavaPovratakButton.Location = new System.Drawing.Point(-2, 473);
            this.prijavaPovratakButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prijavaPovratakButton.Name = "prijavaPovratakButton";
            this.prijavaPovratakButton.Size = new System.Drawing.Size(285, 43);
            this.prijavaPovratakButton.TabIndex = 0;
            this.prijavaPovratakButton.Text = "Prijava";
            this.prijavaPovratakButton.UseVisualStyleBackColor = false;
            this.prijavaPovratakButton.Visible = false;
            this.prijavaPovratakButton.Click += new System.EventHandler(this.prijavaPovratakButton_Click);
            // 
            // posaljiLozinkuButton
            // 
            this.posaljiLozinkuButton.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.posaljiLozinkuButton, BunifuAnimatorNS.DecorationType.None);
            this.posaljiLozinkuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posaljiLozinkuButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.posaljiLozinkuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.posaljiLozinkuButton.Location = new System.Drawing.Point(-2, 412);
            this.posaljiLozinkuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posaljiLozinkuButton.Name = "posaljiLozinkuButton";
            this.posaljiLozinkuButton.Size = new System.Drawing.Size(285, 46);
            this.posaljiLozinkuButton.TabIndex = 1;
            this.posaljiLozinkuButton.Text = "Pošalji lozinku";
            this.posaljiLozinkuButton.UseVisualStyleBackColor = false;
            this.posaljiLozinkuButton.Visible = false;
            this.posaljiLozinkuButton.Click += new System.EventHandler(this.posaljiLozinkuButton_Click);
            // 
            // zaboravljenaLozinkaPorukaLabel
            // 
            this.zaboravljenaLozinkaPorukaLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.zaboravljenaLozinkaPorukaLabel, BunifuAnimatorNS.DecorationType.None);
            this.zaboravljenaLozinkaPorukaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaboravljenaLozinkaPorukaLabel.ForeColor = System.Drawing.Color.White;
            this.zaboravljenaLozinkaPorukaLabel.Location = new System.Drawing.Point(-2, 154);
            this.zaboravljenaLozinkaPorukaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zaboravljenaLozinkaPorukaLabel.Name = "zaboravljenaLozinkaPorukaLabel";
            this.zaboravljenaLozinkaPorukaLabel.Size = new System.Drawing.Size(0, 21);
            this.zaboravljenaLozinkaPorukaLabel.TabIndex = 29;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.btnPrijava, BunifuAnimatorNS.DecorationType.None);
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrijava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnPrijava.Location = new System.Drawing.Point(-2, 473);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(285, 43);
            this.btnPrijava.TabIndex = 23;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_click);
            // 
            // btnZaboravljenaLozinka
            // 
            this.btnZaboravljenaLozinka.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnZaboravljenaLozinka, BunifuAnimatorNS.DecorationType.None);
            this.btnZaboravljenaLozinka.FlatAppearance.BorderSize = 0;
            this.btnZaboravljenaLozinka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnZaboravljenaLozinka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnZaboravljenaLozinka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaboravljenaLozinka.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnZaboravljenaLozinka.ForeColor = System.Drawing.Color.White;
            this.btnZaboravljenaLozinka.Location = new System.Drawing.Point(0, 422);
            this.btnZaboravljenaLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZaboravljenaLozinka.Name = "btnZaboravljenaLozinka";
            this.btnZaboravljenaLozinka.Size = new System.Drawing.Size(285, 43);
            this.btnZaboravljenaLozinka.TabIndex = 27;
            this.btnZaboravljenaLozinka.Text = "Zaboravili ste lozinku?";
            this.btnZaboravljenaLozinka.UseVisualStyleBackColor = false;
            this.btnZaboravljenaLozinka.Click += new System.EventHandler(this.btnZaboravljenaLozinka_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-79, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(469, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnPrebaciNaRegistraciju);
            this.panelLeft.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(318, 596);
            this.panelLeft.TabIndex = 2;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // btnPrebaciNaRegistraciju
            // 
            this.btnPrebaciNaRegistraciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.bunifuTransition1.SetDecoration(this.btnPrebaciNaRegistraciju, BunifuAnimatorNS.DecorationType.None);
            this.btnPrebaciNaRegistraciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrebaciNaRegistraciju.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrebaciNaRegistraciju.ForeColor = System.Drawing.Color.White;
            this.btnPrebaciNaRegistraciju.Location = new System.Drawing.Point(16, 515);
            this.btnPrebaciNaRegistraciju.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrebaciNaRegistraciju.Name = "btnPrebaciNaRegistraciju";
            this.btnPrebaciNaRegistraciju.Size = new System.Drawing.Size(285, 43);
            this.btnPrebaciNaRegistraciju.TabIndex = 0;
            this.btnPrebaciNaRegistraciju.Text = "Registriraj se";
            this.btnPrebaciNaRegistraciju.UseVisualStyleBackColor = false;
            this.btnPrebaciNaRegistraciju.Click += new System.EventHandler(this.btnPrebaciNaRegistraciju_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.panelRight.Controls.Add(this.bunifuPrijavaKorIme);
            this.panelRight.Controls.Add(this.bunifuPrijavaLozinka);
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.label11);
            this.panelRight.Controls.Add(this.label12);
            this.panelRight.Controls.Add(this.panelPrijava);
            this.panelRight.Controls.Add(this.lblPrijavaExit);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.bunifuCheckbox1);
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.bunifuMaterialTextbox4);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelRight.Controls.Add(this.bunifuMaterialTextbox3);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.labelSignUp);
            this.panelRight.Controls.Add(this.panelRegistracija);
            this.bunifuTransition1.SetDecoration(this.panelRight, BunifuAnimatorNS.DecorationType.None);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(643, 596);
            this.panelRight.TabIndex = 3;
            // 
            // lblPrijavaExit
            // 
            this.lblPrijavaExit.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblPrijavaExit, BunifuAnimatorNS.DecorationType.None);
            this.lblPrijavaExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijavaExit.ForeColor = System.Drawing.Color.White;
            this.lblPrijavaExit.Location = new System.Drawing.Point(596, 7);
            this.lblPrijavaExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrijavaExit.Name = "lblPrijavaExit";
            this.lblPrijavaExit.Size = new System.Drawing.Size(31, 33);
            this.lblPrijavaExit.TabIndex = 12;
            this.lblPrijavaExit.Text = "X";
            this.lblPrijavaExit.Click += new System.EventHandler(this.lblPrijavaExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prihvaćam Uvjete korištenja";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.bunifuCheckbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.bunifuCheckbox1.Location = new System.Drawing.Point(37, 483);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.button1.Location = new System.Drawing.Point(26, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registriraj se";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "imeprezime@primjer.com";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(26, 435);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox4.TabIndex = 8;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Ime i Prezime";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(26, 163);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox1.TabIndex = 6;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "Unesite lozinku";
            this.bunifuMaterialTextbox3.isPassword = true;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(26, 349);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox3.TabIndex = 5;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ponovno unesite lozinku:";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "Unesite lozinku";
            this.bunifuMaterialTextbox2.isPassword = true;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(26, 247);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(284, 27);
            this.bunifuMaterialTextbox2.TabIndex = 3;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Korisničko ime:";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignUp, BunifuAnimatorNS.DecorationType.None);
            this.labelSignUp.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.White;
            this.labelSignUp.Location = new System.Drawing.Point(20, 77);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(166, 33);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "Registracija";
            // 
            // panelRegistracija
            // 
            this.bunifuTransition1.SetDecoration(this.panelRegistracija, BunifuAnimatorNS.DecorationType.None);
            this.panelRegistracija.Location = new System.Drawing.Point(25, 66);
            this.panelRegistracija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRegistracija.Name = "panelRegistracija";
            this.panelRegistracija.Size = new System.Drawing.Size(286, 495);
            this.panelRegistracija.TabIndex = 13;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 5000;
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 596);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrijavaForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava RentReady";
            this.panelPrijava.ResumeLayout(false);
            this.panelPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuPrijavaKorIme;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuPrijavaLozinka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelPrijava;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnPrebaciNaRegistraciju;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblPrijavaExit;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Panel panelRegistracija;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnZaboravljenaLozinka;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label zaboravljenaLozinkaPorukaLabel;
        private System.Windows.Forms.Button posaljiLozinkuButton;
        private System.Windows.Forms.Button prijavaPovratakButton;
        private System.Windows.Forms.Label lozinkaJePoslanaLabel;
    }
}