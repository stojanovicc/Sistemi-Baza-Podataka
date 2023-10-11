namespace Bolnica.Forme
{
    partial class PregledStomatoloskihStolica
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
            this.stolice = new System.Windows.Forms.ListView();
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDodajStolicu = new System.Windows.Forms.Button();
            this.buttonIzmeniStolicu = new System.Windows.Forms.Button();
            this.buttonObrisiStolicu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stolice
            // 
            this.stolice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Proizvodjac,
            this.DatumProizvodnje});
            this.stolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stolice.GridLines = true;
            this.stolice.HideSelection = false;
            this.stolice.Location = new System.Drawing.Point(4, 22);
            this.stolice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stolice.Name = "stolice";
            this.stolice.Size = new System.Drawing.Size(271, 290);
            this.stolice.TabIndex = 0;
            this.stolice.UseCompatibleStateImageBehavior = false;
            this.stolice.View = System.Windows.Forms.View.Details;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Text = "Proizvodjac";
            this.Proizvodjac.Width = 118;
            // 
            // DatumProizvodnje
            // 
            this.DatumProizvodnje.Text = "Datum prozivodnje";
            this.DatumProizvodnje.Width = 144;
            // 
            // buttonDodajStolicu
            // 
            this.buttonDodajStolicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDodajStolicu.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDodajStolicu.ForeColor = System.Drawing.Color.Snow;
            this.buttonDodajStolicu.Location = new System.Drawing.Point(279, 177);
            this.buttonDodajStolicu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajStolicu.Name = "buttonDodajStolicu";
            this.buttonDodajStolicu.Size = new System.Drawing.Size(227, 40);
            this.buttonDodajStolicu.TabIndex = 1;
            this.buttonDodajStolicu.Text = "Dodaj stomatolosku stolicu";
            this.buttonDodajStolicu.UseVisualStyleBackColor = false;
            this.buttonDodajStolicu.Click += new System.EventHandler(this.buttonDodajOdeljenje_Click);
            // 
            // buttonIzmeniStolicu
            // 
            this.buttonIzmeniStolicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonIzmeniStolicu.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonIzmeniStolicu.ForeColor = System.Drawing.Color.Snow;
            this.buttonIzmeniStolicu.Location = new System.Drawing.Point(279, 221);
            this.buttonIzmeniStolicu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniStolicu.Name = "buttonIzmeniStolicu";
            this.buttonIzmeniStolicu.Size = new System.Drawing.Size(227, 43);
            this.buttonIzmeniStolicu.TabIndex = 2;
            this.buttonIzmeniStolicu.Text = "Izmeni stomatolosku stolicu";
            this.buttonIzmeniStolicu.UseVisualStyleBackColor = false;
            this.buttonIzmeniStolicu.Click += new System.EventHandler(this.buttonIzmeniOdeljenje_Click);
            // 
            // buttonObrisiStolicu
            // 
            this.buttonObrisiStolicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonObrisiStolicu.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonObrisiStolicu.ForeColor = System.Drawing.Color.Snow;
            this.buttonObrisiStolicu.Location = new System.Drawing.Point(279, 268);
            this.buttonObrisiStolicu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonObrisiStolicu.Name = "buttonObrisiStolicu";
            this.buttonObrisiStolicu.Size = new System.Drawing.Size(227, 44);
            this.buttonObrisiStolicu.TabIndex = 3;
            this.buttonObrisiStolicu.Text = "Obrisi stomatolosku stolicu";
            this.buttonObrisiStolicu.UseVisualStyleBackColor = false;
            this.buttonObrisiStolicu.Click += new System.EventHandler(this.buttonObrisiOdeljenje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stolice);
            this.groupBox1.Controls.Add(this.buttonObrisiStolicu);
            this.groupBox1.Controls.Add(this.buttonDodajStolicu);
            this.groupBox1.Controls.Add(this.buttonIzmeniStolicu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(527, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled stomatoloskih stolica";
            // 
            // PregledStomatoloskihStolica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(547, 346);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(563, 385);
            this.MinimumSize = new System.Drawing.Size(563, 385);
            this.Name = "PregledStomatoloskihStolica";
            this.Text = "Pregled stomatoloskih stolica";
            this.Load += new System.EventHandler(this.OdeljenjaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView stolice;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ColumnHeader DatumProizvodnje;
        private System.Windows.Forms.Button buttonDodajStolicu;
        private System.Windows.Forms.Button buttonIzmeniStolicu;
        private System.Windows.Forms.Button buttonObrisiStolicu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}