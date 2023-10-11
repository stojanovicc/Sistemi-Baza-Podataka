namespace Bolnica.Forme
{
    partial class PacijentiForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacijentiForma));
            this.buttonStacionarni = new System.Windows.Forms.Button();
            this.buttonAmbulantni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStacionarni
            // 
            this.buttonStacionarni.BackColor = System.Drawing.Color.Orange;
            this.buttonStacionarni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonStacionarni.ForeColor = System.Drawing.Color.Snow;
            this.buttonStacionarni.Location = new System.Drawing.Point(228, 224);
            this.buttonStacionarni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStacionarni.Name = "buttonStacionarni";
            this.buttonStacionarni.Size = new System.Drawing.Size(195, 55);
            this.buttonStacionarni.TabIndex = 0;
            this.buttonStacionarni.Text = "PREGLED STACIONARNIH PACIJENATA";
            this.buttonStacionarni.UseVisualStyleBackColor = false;
            this.buttonStacionarni.Click += new System.EventHandler(this.buttonStacionarni_Click);
            // 
            // buttonAmbulantni
            // 
            this.buttonAmbulantni.BackColor = System.Drawing.Color.Orange;
            this.buttonAmbulantni.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAmbulantni.ForeColor = System.Drawing.Color.Snow;
            this.buttonAmbulantni.Location = new System.Drawing.Point(5, 224);
            this.buttonAmbulantni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAmbulantni.Name = "buttonAmbulantni";
            this.buttonAmbulantni.Size = new System.Drawing.Size(195, 55);
            this.buttonAmbulantni.TabIndex = 1;
            this.buttonAmbulantni.Text = "PREGLED AMBULANTNIH PACIJENATA";
            this.buttonAmbulantni.UseVisualStyleBackColor = false;
            this.buttonAmbulantni.Click += new System.EventHandler(this.buttonAmbulantni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonStacionarni);
            this.groupBox1.Controls.Add(this.buttonAmbulantni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled pacijenata";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 128);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // PacijentiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(452, 367);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(468, 406);
            this.MinimumSize = new System.Drawing.Size(468, 406);
            this.Name = "PacijentiForma";
            this.Text = "PacijentiForma";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStacionarni;
        private System.Windows.Forms.Button buttonAmbulantni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}