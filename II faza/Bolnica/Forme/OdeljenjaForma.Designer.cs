namespace Bolnica.Forme
{
    partial class OdeljenjaForma
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
            this.odeljenja = new System.Windows.Forms.ListView();
            this.Sifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipOdeljenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumIzgradnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDodajOdeljenje = new System.Windows.Forms.Button();
            this.buttonIzmeniOdeljenje = new System.Windows.Forms.Button();
            this.buttonObrisiOdeljenje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odeljenja
            // 
            this.odeljenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sifra,
            this.TipOdeljenja,
            this.DatumIzgradnje});
            this.odeljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odeljenja.GridLines = true;
            this.odeljenja.HideSelection = false;
            this.odeljenja.Location = new System.Drawing.Point(4, 21);
            this.odeljenja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.odeljenja.Name = "odeljenja";
            this.odeljenja.Size = new System.Drawing.Size(400, 290);
            this.odeljenja.TabIndex = 0;
            this.odeljenja.UseCompatibleStateImageBehavior = false;
            this.odeljenja.View = System.Windows.Forms.View.Details;
            // 
            // Sifra
            // 
            this.Sifra.Text = "Sifra";
            this.Sifra.Width = 75;
            // 
            // TipOdeljenja
            // 
            this.TipOdeljenja.Text = "Tip odeljenja";
            this.TipOdeljenja.Width = 159;
            // 
            // DatumIzgradnje
            // 
            this.DatumIzgradnje.Text = "Datum Izgradnje";
            this.DatumIzgradnje.Width = 159;
            // 
            // buttonDodajOdeljenje
            // 
            this.buttonDodajOdeljenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajOdeljenje.ForeColor = System.Drawing.Color.Snow;
            this.buttonDodajOdeljenje.Location = new System.Drawing.Point(408, 21);
            this.buttonDodajOdeljenje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajOdeljenje.Name = "buttonDodajOdeljenje";
            this.buttonDodajOdeljenje.Size = new System.Drawing.Size(131, 40);
            this.buttonDodajOdeljenje.TabIndex = 1;
            this.buttonDodajOdeljenje.Text = "Dodaj odeljenje";
            this.buttonDodajOdeljenje.UseVisualStyleBackColor = false;
            this.buttonDodajOdeljenje.Click += new System.EventHandler(this.buttonDodajOdeljenje_Click);
            // 
            // buttonIzmeniOdeljenje
            // 
            this.buttonIzmeniOdeljenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonIzmeniOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmeniOdeljenje.ForeColor = System.Drawing.Color.Snow;
            this.buttonIzmeniOdeljenje.Location = new System.Drawing.Point(408, 65);
            this.buttonIzmeniOdeljenje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniOdeljenje.Name = "buttonIzmeniOdeljenje";
            this.buttonIzmeniOdeljenje.Size = new System.Drawing.Size(131, 43);
            this.buttonIzmeniOdeljenje.TabIndex = 2;
            this.buttonIzmeniOdeljenje.Text = "Izmeni odeljenje";
            this.buttonIzmeniOdeljenje.UseVisualStyleBackColor = false;
            this.buttonIzmeniOdeljenje.Click += new System.EventHandler(this.buttonIzmeniOdeljenje_Click);
            // 
            // buttonObrisiOdeljenje
            // 
            this.buttonObrisiOdeljenje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonObrisiOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonObrisiOdeljenje.ForeColor = System.Drawing.Color.Snow;
            this.buttonObrisiOdeljenje.Location = new System.Drawing.Point(408, 112);
            this.buttonObrisiOdeljenje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonObrisiOdeljenje.Name = "buttonObrisiOdeljenje";
            this.buttonObrisiOdeljenje.Size = new System.Drawing.Size(131, 44);
            this.buttonObrisiOdeljenje.TabIndex = 3;
            this.buttonObrisiOdeljenje.Text = "Obrisi odeljenje";
            this.buttonObrisiOdeljenje.UseVisualStyleBackColor = false;
            this.buttonObrisiOdeljenje.Click += new System.EventHandler(this.buttonObrisiOdeljenje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odeljenja);
            this.groupBox1.Controls.Add(this.buttonObrisiOdeljenje);
            this.groupBox1.Controls.Add(this.buttonDodajOdeljenje);
            this.groupBox1.Controls.Add(this.buttonIzmeniOdeljenje);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(554, 328);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled odeljenja";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // OdeljenjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(575, 348);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(591, 387);
            this.MinimumSize = new System.Drawing.Size(591, 387);
            this.Name = "OdeljenjaForma";
            this.Text = "PregledOdeljenja";
            this.Load += new System.EventHandler(this.OdeljenjaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView odeljenja;
        private System.Windows.Forms.ColumnHeader Sifra;
        private System.Windows.Forms.ColumnHeader TipOdeljenja;
        private System.Windows.Forms.ColumnHeader DatumIzgradnje;
        private System.Windows.Forms.Button buttonDodajOdeljenje;
        private System.Windows.Forms.Button buttonIzmeniOdeljenje;
        private System.Windows.Forms.Button buttonObrisiOdeljenje;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}