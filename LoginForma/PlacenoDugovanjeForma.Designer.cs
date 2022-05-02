namespace LoginForma
{
    partial class PlacenoDugovanjeForma
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
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.uplacenaStanarinaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Location = new System.Drawing.Point(192, 64);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(106, 22);
            this.iznosTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primljeni iznos:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Image = global::LoginForma.Properties.Resources.close_browser;
            this.odustaniButton.Location = new System.Drawing.Point(240, 125);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(90, 31);
            this.odustaniButton.TabIndex = 3;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.Image = global::LoginForma.Properties.Resources.check_mark;
            this.potvrdiButton.Location = new System.Drawing.Point(149, 125);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(85, 31);
            this.potvrdiButton.TabIndex = 2;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // uplacenaStanarinaButton
            // 
            this.uplacenaStanarinaButton.Image = global::LoginForma.Properties.Resources.check_mark;
            this.uplacenaStanarinaButton.Location = new System.Drawing.Point(12, 113);
            this.uplacenaStanarinaButton.Name = "uplacenaStanarinaButton";
            this.uplacenaStanarinaButton.Size = new System.Drawing.Size(115, 43);
            this.uplacenaStanarinaButton.TabIndex = 4;
            this.uplacenaStanarinaButton.Text = "Uplacena stanarina";
            this.uplacenaStanarinaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uplacenaStanarinaButton.UseVisualStyleBackColor = true;
            this.uplacenaStanarinaButton.Click += new System.EventHandler(this.uplacenaStanarinaButton_Click);
            // 
            // PlacenoDugovanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.uplacenaStanarinaButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iznosTextBox);
            this.Name = "PlacenoDugovanjeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plaćeno dugovanje";
            this.Load += new System.EventHandler(this.PlacenoDugovanjeForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button uplacenaStanarinaButton;
    }
}