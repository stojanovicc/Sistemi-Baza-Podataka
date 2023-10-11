namespace Bolnica.Forme
{
    partial class DodajSmenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSmena = new System.Windows.Forms.TextBox();
            this.buttonDodajSmenu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip smene:";
            // 
            // textBoxSmena
            // 
            this.textBoxSmena.Location = new System.Drawing.Point(89, 43);
            this.textBoxSmena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSmena.Name = "textBoxSmena";
            this.textBoxSmena.Size = new System.Drawing.Size(155, 24);
            this.textBoxSmena.TabIndex = 2;
            // 
            // buttonDodajSmenu
            // 
            this.buttonDodajSmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajSmenu.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajSmenu.Location = new System.Drawing.Point(118, 192);
            this.buttonDodajSmenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajSmenu.MaximumSize = new System.Drawing.Size(126, 33);
            this.buttonDodajSmenu.MinimumSize = new System.Drawing.Size(126, 33);
            this.buttonDodajSmenu.Name = "buttonDodajSmenu";
            this.buttonDodajSmenu.Size = new System.Drawing.Size(126, 33);
            this.buttonDodajSmenu.TabIndex = 3;
            this.buttonDodajSmenu.Text = "Dodaj smenu";
            this.buttonDodajSmenu.UseVisualStyleBackColor = false;
            this.buttonDodajSmenu.Click += new System.EventHandler(this.buttonDodajSmenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDodajSmenu);
            this.groupBox1.Controls.Add(this.textBoxSmena);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(257, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o smeni";
            // 
            // DodajSmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(275, 248);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajSmenu";
            this.Text = "DodajSmenu";
            this.Load += new System.EventHandler(this.DodajSmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSmena;
        private System.Windows.Forms.Button buttonDodajSmenu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}