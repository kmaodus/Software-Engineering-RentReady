namespace LoginForma
{
    partial class RegistracijaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistracijaForma));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPrebaciNaPrijavu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblRegistracijaExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.panelRegistracija = new System.Windows.Forms.Panel();
            this.bunifuRegistracijaPrezime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuRegistracijaIme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuRegistracijaOIB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuRegistracijaEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuRegistracijaKorIme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.bunifuRegistracijaLozinka = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelRegistracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.btnPrebaciNaPrijavu);
            this.panelLeft.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(318, 633);
            this.panelLeft.TabIndex = 0;
            // 
            // btnPrebaciNaPrijavu
            // 
            this.btnPrebaciNaPrijavu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.bunifuTransition1.SetDecoration(this.btnPrebaciNaPrijavu, BunifuAnimatorNS.DecorationType.None);
            this.btnPrebaciNaPrijavu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrebaciNaPrijavu.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrebaciNaPrijavu.ForeColor = System.Drawing.Color.White;
            this.btnPrebaciNaPrijavu.Location = new System.Drawing.Point(9, 566);
            this.btnPrebaciNaPrijavu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrebaciNaPrijavu.Name = "btnPrebaciNaPrijavu";
            this.btnPrebaciNaPrijavu.Size = new System.Drawing.Size(285, 43);
            this.btnPrebaciNaPrijavu.TabIndex = 0;
            this.btnPrebaciNaPrijavu.TabStop = false;
            this.btnPrebaciNaPrijavu.Text = "Prijavi se";
            this.btnPrebaciNaPrijavu.UseVisualStyleBackColor = false;
            this.btnPrebaciNaPrijavu.Click += new System.EventHandler(this.btnPrijava_Click);
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.panelRight.Controls.Add(this.lblRegistracijaExit);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.btnRegistracija);
            this.panelRight.Controls.Add(this.panelRegistracija);
            this.bunifuTransition1.SetDecoration(this.panelRight, BunifuAnimatorNS.DecorationType.None);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(318, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(320, 633);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // lblRegistracijaExit
            // 
            this.lblRegistracijaExit.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblRegistracijaExit, BunifuAnimatorNS.DecorationType.None);
            this.lblRegistracijaExit.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracijaExit.ForeColor = System.Drawing.Color.White;
            this.lblRegistracijaExit.Location = new System.Drawing.Point(282, 0);
            this.lblRegistracijaExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistracijaExit.Name = "lblRegistracijaExit";
            this.lblRegistracijaExit.Size = new System.Drawing.Size(31, 33);
            this.lblRegistracijaExit.TabIndex = 12;
            this.lblRegistracijaExit.Text = "X";
            this.lblRegistracijaExit.Click += new System.EventHandler(this.lblRegistracijaExit_Click);
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
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prezime:";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.btnRegistracija, BunifuAnimatorNS.DecorationType.None);
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegistracija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.btnRegistracija.Location = new System.Drawing.Point(22, 566);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(285, 43);
            this.btnRegistracija.TabIndex = 0;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // panelRegistracija
            // 
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaPrezime);
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaIme);
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaOIB);
            this.panelRegistracija.Controls.Add(this.bunifuCheckbox1);
            this.panelRegistracija.Controls.Add(this.label3);
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaEmail);
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaKorIme);
            this.panelRegistracija.Controls.Add(this.label4);
            this.panelRegistracija.Controls.Add(this.lblKorIme);
            this.panelRegistracija.Controls.Add(this.button5);
            this.panelRegistracija.Controls.Add(this.label5);
            this.panelRegistracija.Controls.Add(this.labelSignUp);
            this.panelRegistracija.Controls.Add(this.bunifuRegistracijaLozinka);
            this.panelRegistracija.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panelRegistracija, BunifuAnimatorNS.DecorationType.None);
            this.panelRegistracija.Location = new System.Drawing.Point(25, 10);
            this.panelRegistracija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRegistracija.Name = "panelRegistracija";
            this.panelRegistracija.Size = new System.Drawing.Size(286, 551);
            this.panelRegistracija.TabIndex = 0;
            // 
            // bunifuRegistracijaPrezime
            // 
            this.bunifuRegistracijaPrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaPrezime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaPrezime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaPrezime.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaPrezime.HintText = "Prezime";
            this.bunifuRegistracijaPrezime.isPassword = false;
            this.bunifuRegistracijaPrezime.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaPrezime.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaPrezime.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaPrezime.LineThickness = 3;
            this.bunifuRegistracijaPrezime.Location = new System.Drawing.Point(0, 154);
            this.bunifuRegistracijaPrezime.Name = "bunifuRegistracijaPrezime";
            this.bunifuRegistracijaPrezime.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaPrezime.TabIndex = 1;
            this.bunifuRegistracijaPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuRegistracijaIme
            // 
            this.bunifuRegistracijaIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaIme, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaIme.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaIme.HintText = "Ime";
            this.bunifuRegistracijaIme.isPassword = false;
            this.bunifuRegistracijaIme.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaIme.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaIme.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaIme.LineThickness = 3;
            this.bunifuRegistracijaIme.Location = new System.Drawing.Point(2, 80);
            this.bunifuRegistracijaIme.Name = "bunifuRegistracijaIme";
            this.bunifuRegistracijaIme.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaIme.TabIndex = 0;
            this.bunifuRegistracijaIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuRegistracijaOIB
            // 
            this.bunifuRegistracijaOIB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaOIB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaOIB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaOIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaOIB.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaOIB.HintText = "OIB";
            this.bunifuRegistracijaOIB.isPassword = false;
            this.bunifuRegistracijaOIB.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaOIB.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaOIB.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaOIB.LineThickness = 3;
            this.bunifuRegistracijaOIB.Location = new System.Drawing.Point(3, 394);
            this.bunifuRegistracijaOIB.Name = "bunifuRegistracijaOIB";
            this.bunifuRegistracijaOIB.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaOIB.TabIndex = 4;
            this.bunifuRegistracijaOIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.bunifuCheckbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.bunifuCheckbox1.Location = new System.Drawing.Point(15, 522);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "OIB:";
            // 
            // bunifuRegistracijaEmail
            // 
            this.bunifuRegistracijaEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaEmail, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaEmail.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaEmail.HintText = "imeprezime@primjer.com";
            this.bunifuRegistracijaEmail.isPassword = false;
            this.bunifuRegistracijaEmail.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaEmail.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaEmail.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaEmail.LineThickness = 3;
            this.bunifuRegistracijaEmail.Location = new System.Drawing.Point(-2, 448);
            this.bunifuRegistracijaEmail.Name = "bunifuRegistracijaEmail";
            this.bunifuRegistracijaEmail.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaEmail.TabIndex = 5;
            this.bunifuRegistracijaEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuRegistracijaKorIme
            // 
            this.bunifuRegistracijaKorIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaKorIme, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaKorIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaKorIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaKorIme.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaKorIme.HintText = "Korisničko ime";
            this.bunifuRegistracijaKorIme.isPassword = false;
            this.bunifuRegistracijaKorIme.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaKorIme.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaKorIme.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaKorIme.LineThickness = 3;
            this.bunifuRegistracijaKorIme.Location = new System.Drawing.Point(2, 239);
            this.bunifuRegistracijaKorIme.Name = "bunifuRegistracijaKorIme";
            this.bunifuRegistracijaKorIme.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaKorIme.TabIndex = 2;
            this.bunifuRegistracijaKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 427);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email:";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblKorIme, BunifuAnimatorNS.DecorationType.None);
            this.lblKorIme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.ForeColor = System.Drawing.Color.White;
            this.lblKorIme.Location = new System.Drawing.Point(-2, 206);
            this.lblKorIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(120, 21);
            this.lblKorIme.TabIndex = 30;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 505);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 43);
            this.button5.TabIndex = 6;
            this.button5.Text = "Prihvaćam Uvjete korištenja";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ime:";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelSignUp, BunifuAnimatorNS.DecorationType.None);
            this.labelSignUp.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.Color.White;
            this.labelSignUp.Location = new System.Drawing.Point(-5, 0);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(166, 33);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "Registracija";
            // 
            // bunifuRegistracijaLozinka
            // 
            this.bunifuRegistracijaLozinka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuRegistracijaLozinka, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRegistracijaLozinka.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuRegistracijaLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuRegistracijaLozinka.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuRegistracijaLozinka.HintText = "Unesite lozinku";
            this.bunifuRegistracijaLozinka.isPassword = true;
            this.bunifuRegistracijaLozinka.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuRegistracijaLozinka.LineIdleColor = System.Drawing.Color.White;
            this.bunifuRegistracijaLozinka.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuRegistracijaLozinka.LineThickness = 3;
            this.bunifuRegistracijaLozinka.Location = new System.Drawing.Point(2, 322);
            this.bunifuRegistracijaLozinka.Name = "bunifuRegistracijaLozinka";
            this.bunifuRegistracijaLozinka.Size = new System.Drawing.Size(284, 27);
            this.bunifuRegistracijaLozinka.TabIndex = 3;
            this.bunifuRegistracijaLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Lozinka:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
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
            // RegistracijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 633);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistracijaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija RentReady";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelRegistracija.ResumeLayout(false);
            this.panelRegistracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSignUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaPrezime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaLozinka;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label lblRegistracijaExit;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelRegistracija;
        private System.Windows.Forms.Button btnPrebaciNaPrijavu;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button button5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaIme;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaKorIme;
        private System.Windows.Forms.Label lblKorIme;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuRegistracijaOIB;
        private System.Windows.Forms.Label label3;
    }
}

