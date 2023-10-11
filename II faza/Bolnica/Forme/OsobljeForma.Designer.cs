namespace Bolnica.Forme
{
    partial class OsobljeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsobljeForma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNemedicinsko = new System.Windows.Forms.Button();
            this.buttonMedicinsko = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonNemedicinsko);
            this.groupBox1.Controls.Add(this.buttonMedicinsko);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(491, 403);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled osoblja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(147, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonNemedicinsko
            // 
            this.buttonNemedicinsko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNemedicinsko.Location = new System.Drawing.Point(259, 309);
            this.buttonNemedicinsko.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNemedicinsko.Name = "buttonNemedicinsko";
            this.buttonNemedicinsko.Size = new System.Drawing.Size(228, 79);
            this.buttonNemedicinsko.TabIndex = 0;
            this.buttonNemedicinsko.Text = "PREGLED NEMEDICINSKOG OSOBLJA";
            this.buttonNemedicinsko.UseVisualStyleBackColor = false;
            this.buttonNemedicinsko.Click += new System.EventHandler(this.buttonNemedicinsko_Click);
            // 
            // buttonMedicinsko
            // 
            this.buttonMedicinsko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMedicinsko.Location = new System.Drawing.Point(4, 309);
            this.buttonMedicinsko.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMedicinsko.Name = "buttonMedicinsko";
            this.buttonMedicinsko.Size = new System.Drawing.Size(228, 79);
            this.buttonMedicinsko.TabIndex = 0;
            this.buttonMedicinsko.Text = "PREGLED MEDICINSKOG OSOBLJA";
            this.buttonMedicinsko.UseVisualStyleBackColor = false;
            this.buttonMedicinsko.Click += new System.EventHandler(this.buttonMedicinsko_Click);
            // 
            // OsobljeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(511, 427);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(527, 466);
            this.MinimumSize = new System.Drawing.Size(527, 466);
            this.Name = "OsobljeForma";
            this.Text = "OsobljeForma";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNemedicinsko;
        private System.Windows.Forms.Button buttonMedicinsko;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}