namespace Bolnica.Forme
{
    partial class IzmeniPacijentStacionarniForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datumOtpusta = new System.Windows.Forms.DateTimePicker();
            this.datumPrijema = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datumOtpusta);
            this.groupBox1.Controls.Add(this.datumPrijema);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o pacijentu";
            // 
            // datumOtpusta
            // 
            this.datumOtpusta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOtpusta.Location = new System.Drawing.Point(128, 133);
            this.datumOtpusta.Name = "datumOtpusta";
            this.datumOtpusta.Size = new System.Drawing.Size(204, 24);
            this.datumOtpusta.TabIndex = 10;
            // 
            // datumPrijema
            // 
            this.datumPrijema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumPrijema.Location = new System.Drawing.Point(128, 103);
            this.datumPrijema.Name = "datumPrijema";
            this.datumPrijema.Size = new System.Drawing.Size(204, 24);
            this.datumPrijema.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(229, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "IZMENI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(128, 73);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(204, 24);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(128, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(204, 24);
            this.txtIme.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum prijema :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum otpusta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime :";
            // 
            // oracleCommandBuilder1
            // 
            this.oracleCommandBuilder1.CatalogLocation = System.Data.Common.CatalogLocation.End;
            this.oracleCommandBuilder1.CatalogSeparator = "@";
            // 
            // IzmeniPacijentStacionarniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(364, 296);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(380, 335);
            this.MinimumSize = new System.Drawing.Size(380, 335);
            this.Name = "IzmeniPacijentStacionarniForma";
            this.Text = "IzmeniPacijentStacionarniForma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datumOtpusta;
        private System.Windows.Forms.DateTimePicker datumPrijema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
    }
}