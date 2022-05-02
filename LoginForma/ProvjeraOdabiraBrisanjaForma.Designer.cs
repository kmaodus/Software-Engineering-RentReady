namespace LoginForma
{
    partial class ProvjeraOdabiraBrisanjaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.daButton = new System.Windows.Forms.Button();
            this.neButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jeste li sigurni da želite obrisati odabrani zapis?";
            // 
            // daButton
            // 
            this.daButton.Location = new System.Drawing.Point(48, 78);
            this.daButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.daButton.Name = "daButton";
            this.daButton.Size = new System.Drawing.Size(70, 41);
            this.daButton.TabIndex = 0;
            this.daButton.Text = "Da";
            this.daButton.UseVisualStyleBackColor = true;
            this.daButton.Click += new System.EventHandler(this.daButton_Click);
            // 
            // neButton
            // 
            this.neButton.Location = new System.Drawing.Point(196, 78);
            this.neButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neButton.Name = "neButton";
            this.neButton.Size = new System.Drawing.Size(70, 41);
            this.neButton.TabIndex = 1;
            this.neButton.Text = "Ne";
            this.neButton.UseVisualStyleBackColor = true;
            this.neButton.Click += new System.EventHandler(this.neButton_Click);
            // 
            // ProvjeraOdabiraBrisanjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 159);
            this.Controls.Add(this.neButton);
            this.Controls.Add(this.daButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProvjeraOdabiraBrisanjaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button daButton;
        private System.Windows.Forms.Button neButton;
    }
}