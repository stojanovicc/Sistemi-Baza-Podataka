namespace Bolnica
{
    partial class Form1
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
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdReadSmena = new System.Windows.Forms.Button();
            this.cmdCreateSmena = new System.Windows.Forms.Button();
            this.cmdManyToOneOdeljenje = new System.Windows.Forms.Button();
            this.cmdOneToManyOdeljenje = new System.Windows.Forms.Button();
            this.cmdCreateStomatoloskaStolica = new System.Windows.Forms.Button();
            this.cmdTPCMedicinsko = new System.Windows.Forms.Button();
            this.cmdTPCNemedicinsko = new System.Windows.Forms.Button();
            this.cmdCreateMedicinsko = new System.Windows.Forms.Button();
            this.cmdCreateNemedicinsko = new System.Windows.Forms.Button();
            this.cmdTPCHPacijent = new System.Windows.Forms.Button();
            this.cmdCreateSubclassPacijent = new System.Windows.Forms.Button();
            this.cmdGetPacijent = new System.Windows.Forms.Button();
            this.cmdManyToOnePacijent = new System.Windows.Forms.Button();
            this.cmdOneToManyPacijent = new System.Windows.Forms.Button();
            this.cmdManyToOneStacionarni = new System.Windows.Forms.Button();
            this.cmdOneToManyStacionarni = new System.Windows.Forms.Button();
            this.cmdCreatePacijenta = new System.Windows.Forms.Button();
            this.cmdlezina = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.smdEnumerable = new System.Windows.Forms.Button();
            this.cmdScalar = new System.Windows.Forms.Button();
            this.cmdMultiple = new System.Windows.Forms.Button();
            this.cmdPaging = new System.Windows.Forms.Button();
            this.cmdCriteria = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdTransaction = new System.Windows.Forms.Button();
            this.cmdCreateOdrzavaHigijenuNa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(9, 8);
            this.cmdRead.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(175, 23);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Ucitavanje podataka o odeljenju";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(9, 154);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(175, 26);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Kreiranje novog odeljenja";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(9, 187);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(175, 34);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Veza Many-to-One Stomatoloska_stolica";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(10, 228);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(175, 38);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza One-to-Many Stomatoloska_stolica";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdReadSmena
            // 
            this.cmdReadSmena.Location = new System.Drawing.Point(9, 36);
            this.cmdReadSmena.Name = "cmdReadSmena";
            this.cmdReadSmena.Size = new System.Drawing.Size(175, 23);
            this.cmdReadSmena.TabIndex = 6;
            this.cmdReadSmena.Text = "Ucitavanje podataka o smeni";
            this.cmdReadSmena.UseVisualStyleBackColor = true;
            this.cmdReadSmena.Click += new System.EventHandler(this.cmdReadSmena_Click);
            // 
            // cmdCreateSmena
            // 
            this.cmdCreateSmena.Location = new System.Drawing.Point(9, 65);
            this.cmdCreateSmena.Name = "cmdCreateSmena";
            this.cmdCreateSmena.Size = new System.Drawing.Size(175, 24);
            this.cmdCreateSmena.TabIndex = 7;
            this.cmdCreateSmena.Text = "Dodavanje nove smene";
            this.cmdCreateSmena.UseVisualStyleBackColor = true;
            this.cmdCreateSmena.Click += new System.EventHandler(this.cmdCreateSmena_Click);
            // 
            // cmdManyToOneOdeljenje
            // 
            this.cmdManyToOneOdeljenje.Location = new System.Drawing.Point(9, 96);
            this.cmdManyToOneOdeljenje.Name = "cmdManyToOneOdeljenje";
            this.cmdManyToOneOdeljenje.Size = new System.Drawing.Size(175, 21);
            this.cmdManyToOneOdeljenje.TabIndex = 8;
            this.cmdManyToOneOdeljenje.Text = "Veza Many-to-One Odeljenje";
            this.cmdManyToOneOdeljenje.UseVisualStyleBackColor = true;
            this.cmdManyToOneOdeljenje.Click += new System.EventHandler(this.cmdManyToOneOdeljenje_Click);
            // 
            // cmdOneToManyOdeljenje
            // 
            this.cmdOneToManyOdeljenje.Location = new System.Drawing.Point(9, 124);
            this.cmdOneToManyOdeljenje.Name = "cmdOneToManyOdeljenje";
            this.cmdOneToManyOdeljenje.Size = new System.Drawing.Size(175, 24);
            this.cmdOneToManyOdeljenje.TabIndex = 9;
            this.cmdOneToManyOdeljenje.Text = "Veza One-to-Many Odeljenje";
            this.cmdOneToManyOdeljenje.UseVisualStyleBackColor = true;
            this.cmdOneToManyOdeljenje.Click += new System.EventHandler(this.cmdOneToManyOdeljenje_Click);
            // 
            // cmdCreateStomatoloskaStolica
            // 
            this.cmdCreateStomatoloskaStolica.Location = new System.Drawing.Point(9, 272);
            this.cmdCreateStomatoloskaStolica.Name = "cmdCreateStomatoloskaStolica";
            this.cmdCreateStomatoloskaStolica.Size = new System.Drawing.Size(175, 23);
            this.cmdCreateStomatoloskaStolica.TabIndex = 10;
            this.cmdCreateStomatoloskaStolica.Text = "Kreiranje nove Stomatoloske stolice";
            this.cmdCreateStomatoloskaStolica.UseVisualStyleBackColor = true;
            this.cmdCreateStomatoloskaStolica.Click += new System.EventHandler(this.cmdCreateStomatoloskaStolica_Click);
            // 
            // cmdTPCMedicinsko
            // 
            this.cmdTPCMedicinsko.Location = new System.Drawing.Point(190, 65);
            this.cmdTPCMedicinsko.Name = "cmdTPCMedicinsko";
            this.cmdTPCMedicinsko.Size = new System.Drawing.Size(151, 34);
            this.cmdTPCMedicinsko.TabIndex = 13;
            this.cmdTPCMedicinsko.Text = "Table-per-Classes inheritance Medicinsko Osoblje";
            this.cmdTPCMedicinsko.UseVisualStyleBackColor = true;
            this.cmdTPCMedicinsko.Click += new System.EventHandler(this.cmdTPCMedicinsko_Click);
            // 
            // cmdTPCNemedicinsko
            // 
            this.cmdTPCNemedicinsko.Location = new System.Drawing.Point(190, 106);
            this.cmdTPCNemedicinsko.Name = "cmdTPCNemedicinsko";
            this.cmdTPCNemedicinsko.Size = new System.Drawing.Size(151, 38);
            this.cmdTPCNemedicinsko.TabIndex = 14;
            this.cmdTPCNemedicinsko.Text = "Table-per-Classes inheritance Nemedicinsko";
            this.cmdTPCNemedicinsko.UseVisualStyleBackColor = true;
            this.cmdTPCNemedicinsko.Click += new System.EventHandler(this.cmdTPCNemedicinsko_Click);
            // 
            // cmdCreateMedicinsko
            // 
            this.cmdCreateMedicinsko.Location = new System.Drawing.Point(190, 150);
            this.cmdCreateMedicinsko.Name = "cmdCreateMedicinsko";
            this.cmdCreateMedicinsko.Size = new System.Drawing.Size(151, 22);
            this.cmdCreateMedicinsko.TabIndex = 15;
            this.cmdCreateMedicinsko.Text = "Kreiranje medicinskog osoblja";
            this.cmdCreateMedicinsko.UseVisualStyleBackColor = true;
            this.cmdCreateMedicinsko.Click += new System.EventHandler(this.cmdCreateMedicinsko_Click);
            // 
            // cmdCreateNemedicinsko
            // 
            this.cmdCreateNemedicinsko.Location = new System.Drawing.Point(190, 179);
            this.cmdCreateNemedicinsko.Name = "cmdCreateNemedicinsko";
            this.cmdCreateNemedicinsko.Size = new System.Drawing.Size(151, 36);
            this.cmdCreateNemedicinsko.TabIndex = 16;
            this.cmdCreateNemedicinsko.Text = "Kreiranje nemedicinskog osoblja";
            this.cmdCreateNemedicinsko.UseVisualStyleBackColor = true;
            this.cmdCreateNemedicinsko.Click += new System.EventHandler(this.cmdCreateNemedicinsko_Click);
            // 
            // cmdTPCHPacijent
            // 
            this.cmdTPCHPacijent.Location = new System.Drawing.Point(190, 221);
            this.cmdTPCHPacijent.Name = "cmdTPCHPacijent";
            this.cmdTPCHPacijent.Size = new System.Drawing.Size(151, 39);
            this.cmdTPCHPacijent.TabIndex = 17;
            this.cmdTPCHPacijent.Text = "Table-per-Class-Hierarchy inheritance Pacijent";
            this.cmdTPCHPacijent.UseVisualStyleBackColor = true;
            this.cmdTPCHPacijent.Click += new System.EventHandler(this.cmdTPCHPacijent_Click);
            // 
            // cmdCreateSubclassPacijent
            // 
            this.cmdCreateSubclassPacijent.Location = new System.Drawing.Point(190, 266);
            this.cmdCreateSubclassPacijent.Name = "cmdCreateSubclassPacijent";
            this.cmdCreateSubclassPacijent.Size = new System.Drawing.Size(151, 24);
            this.cmdCreateSubclassPacijent.TabIndex = 18;
            this.cmdCreateSubclassPacijent.Text = "Kreiranje podklase Pacijent";
            this.cmdCreateSubclassPacijent.UseVisualStyleBackColor = true;
            this.cmdCreateSubclassPacijent.Click += new System.EventHandler(this.cmdCreateSubclassPacijent_Click);
            // 
            // cmdGetPacijent
            // 
            this.cmdGetPacijent.Location = new System.Drawing.Point(190, 297);
            this.cmdGetPacijent.Name = "cmdGetPacijent";
            this.cmdGetPacijent.Size = new System.Drawing.Size(151, 41);
            this.cmdGetPacijent.TabIndex = 19;
            this.cmdGetPacijent.Text = "Koriscenje metode Get Pacijent";
            this.cmdGetPacijent.UseVisualStyleBackColor = true;
            this.cmdGetPacijent.Click += new System.EventHandler(this.cmdGetPacijent_Click);
            // 
            // cmdManyToOnePacijent
            // 
            this.cmdManyToOnePacijent.Location = new System.Drawing.Point(9, 301);
            this.cmdManyToOnePacijent.Margin = new System.Windows.Forms.Padding(2);
            this.cmdManyToOnePacijent.Name = "cmdManyToOnePacijent";
            this.cmdManyToOnePacijent.Size = new System.Drawing.Size(175, 23);
            this.cmdManyToOnePacijent.TabIndex = 20;
            this.cmdManyToOnePacijent.Text = "Veza Many-to-One Pacijent";
            this.cmdManyToOnePacijent.UseVisualStyleBackColor = true;
            this.cmdManyToOnePacijent.Click += new System.EventHandler(this.cmdManyToOnePacijent_Click);
            // 
            // cmdOneToManyPacijent
            // 
            this.cmdOneToManyPacijent.Location = new System.Drawing.Point(9, 328);
            this.cmdOneToManyPacijent.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOneToManyPacijent.Name = "cmdOneToManyPacijent";
            this.cmdOneToManyPacijent.Size = new System.Drawing.Size(175, 22);
            this.cmdOneToManyPacijent.TabIndex = 21;
            this.cmdOneToManyPacijent.Text = "Veza One-to-Many Pacijent";
            this.cmdOneToManyPacijent.UseVisualStyleBackColor = true;
            this.cmdOneToManyPacijent.Click += new System.EventHandler(this.cmdOneToManyPacijent_Click);
            // 
            // cmdManyToOneStacionarni
            // 
            this.cmdManyToOneStacionarni.Location = new System.Drawing.Point(9, 355);
            this.cmdManyToOneStacionarni.Margin = new System.Windows.Forms.Padding(2);
            this.cmdManyToOneStacionarni.Name = "cmdManyToOneStacionarni";
            this.cmdManyToOneStacionarni.Size = new System.Drawing.Size(175, 27);
            this.cmdManyToOneStacionarni.TabIndex = 22;
            this.cmdManyToOneStacionarni.Text = "Veza Many-to-One Stacionarni";
            this.cmdManyToOneStacionarni.UseVisualStyleBackColor = true;
            this.cmdManyToOneStacionarni.Click += new System.EventHandler(this.cmdManyToOneStacionarni_Click);
            // 
            // cmdOneToManyStacionarni
            // 
            this.cmdOneToManyStacionarni.Location = new System.Drawing.Point(190, 8);
            this.cmdOneToManyStacionarni.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOneToManyStacionarni.Name = "cmdOneToManyStacionarni";
            this.cmdOneToManyStacionarni.Size = new System.Drawing.Size(151, 23);
            this.cmdOneToManyStacionarni.TabIndex = 23;
            this.cmdOneToManyStacionarni.Text = "Veza One-to-Many Stacionarni";
            this.cmdOneToManyStacionarni.UseVisualStyleBackColor = true;
            this.cmdOneToManyStacionarni.Click += new System.EventHandler(this.cmdOneToManyStacionarni_Click);
            // 
            // cmdCreatePacijenta
            // 
            this.cmdCreatePacijenta.Location = new System.Drawing.Point(190, 36);
            this.cmdCreatePacijenta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCreatePacijenta.Name = "cmdCreatePacijenta";
            this.cmdCreatePacijenta.Size = new System.Drawing.Size(151, 24);
            this.cmdCreatePacijenta.TabIndex = 24;
            this.cmdCreatePacijenta.Text = "Kreiranje novog Pacijenta";
            this.cmdCreatePacijenta.UseVisualStyleBackColor = true;
            this.cmdCreatePacijenta.Click += new System.EventHandler(this.cmdCreatePacijenta_Click);
            // 
            // cmdlezina
            // 
            this.cmdlezina.Location = new System.Drawing.Point(189, 344);
            this.cmdlezina.Margin = new System.Windows.Forms.Padding(2);
            this.cmdlezina.Name = "cmdlezina";
            this.cmdlezina.Size = new System.Drawing.Size(151, 38);
            this.cmdlezina.TabIndex = 30;
            this.cmdlezina.Text = "Kreiranje veze LEZI_NA";
            this.cmdlezina.UseVisualStyleBackColor = true;
            this.cmdlezina.Click += new System.EventHandler(this.cmdlezina_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(345, 63);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(152, 23);
            this.cmdRefresh.TabIndex = 33;
            this.cmdRefresh.Text = "Koriscenje metode Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // smdEnumerable
            // 
            this.smdEnumerable.Location = new System.Drawing.Point(345, 90);
            this.smdEnumerable.Margin = new System.Windows.Forms.Padding(2);
            this.smdEnumerable.Name = "smdEnumerable";
            this.smdEnumerable.Size = new System.Drawing.Size(152, 23);
            this.smdEnumerable.TabIndex = 39;
            this.smdEnumerable.Text = "Koriscenje Enumerable";
            this.smdEnumerable.UseVisualStyleBackColor = true;
            this.smdEnumerable.Click += new System.EventHandler(this.smdEnumerable_Click);
            // 
            // cmdScalar
            // 
            this.cmdScalar.Location = new System.Drawing.Point(345, 117);
            this.cmdScalar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdScalar.Name = "cmdScalar";
            this.cmdScalar.Size = new System.Drawing.Size(152, 20);
            this.cmdScalar.TabIndex = 40;
            this.cmdScalar.Text = "Skalarni rezultati";
            this.cmdScalar.UseVisualStyleBackColor = true;
            this.cmdScalar.Click += new System.EventHandler(this.cmdScalar_Click);
            // 
            // cmdMultiple
            // 
            this.cmdMultiple.Location = new System.Drawing.Point(345, 141);
            this.cmdMultiple.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMultiple.Name = "cmdMultiple";
            this.cmdMultiple.Size = new System.Drawing.Size(152, 25);
            this.cmdMultiple.TabIndex = 42;
            this.cmdMultiple.Text = "Visestruki rezultati";
            this.cmdMultiple.UseVisualStyleBackColor = true;
            // 
            // cmdPaging
            // 
            this.cmdPaging.Location = new System.Drawing.Point(345, 170);
            this.cmdPaging.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPaging.Name = "cmdPaging";
            this.cmdPaging.Size = new System.Drawing.Size(152, 20);
            this.cmdPaging.TabIndex = 43;
            this.cmdPaging.Text = "Stranicenje";
            this.cmdPaging.UseVisualStyleBackColor = true;
            this.cmdPaging.Click += new System.EventHandler(this.cmdPaging_Click);
            // 
            // cmdCriteria
            // 
            this.cmdCriteria.Location = new System.Drawing.Point(345, 197);
            this.cmdCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCriteria.Name = "cmdCriteria";
            this.cmdCriteria.Size = new System.Drawing.Size(152, 25);
            this.cmdCriteria.TabIndex = 44;
            this.cmdCriteria.Text = "Kreiranje Criteria";
            this.cmdCriteria.UseVisualStyleBackColor = true;
            this.cmdCriteria.Click += new System.EventHandler(this.cmdCriteria_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(345, 226);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(152, 34);
            this.cmdUpdate.TabIndex = 47;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(345, 264);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(152, 28);
            this.cmdDelete.TabIndex = 48;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdTransaction
            // 
            this.cmdTransaction.Location = new System.Drawing.Point(345, 296);
            this.cmdTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTransaction.Name = "cmdTransaction";
            this.cmdTransaction.Size = new System.Drawing.Size(152, 28);
            this.cmdTransaction.TabIndex = 49;
            this.cmdTransaction.Text = "Transakcija";
            this.cmdTransaction.UseVisualStyleBackColor = true;
            this.cmdTransaction.Click += new System.EventHandler(this.cmdTransaction_Click);
            // 
            // cmdCreateOdrzavaHigijenuNa
            // 
            this.cmdCreateOdrzavaHigijenuNa.Location = new System.Drawing.Point(345, 8);
            this.cmdCreateOdrzavaHigijenuNa.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCreateOdrzavaHigijenuNa.Name = "cmdCreateOdrzavaHigijenuNa";
            this.cmdCreateOdrzavaHigijenuNa.Size = new System.Drawing.Size(152, 51);
            this.cmdCreateOdrzavaHigijenuNa.TabIndex = 54;
            this.cmdCreateOdrzavaHigijenuNa.Text = "Kreiranje veze ODRZAVA_HIGIJENU_NA";
            this.cmdCreateOdrzavaHigijenuNa.UseVisualStyleBackColor = true;
            this.cmdCreateOdrzavaHigijenuNa.Click += new System.EventHandler(this.cmdCreateOdrzavaHigijenuNa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 391);
            this.Controls.Add(this.cmdCreateOdrzavaHigijenuNa);
            this.Controls.Add(this.cmdTransaction);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdCriteria);
            this.Controls.Add(this.cmdPaging);
            this.Controls.Add(this.cmdMultiple);
            this.Controls.Add(this.cmdScalar);
            this.Controls.Add(this.smdEnumerable);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdlezina);
            this.Controls.Add(this.cmdCreatePacijenta);
            this.Controls.Add(this.cmdOneToManyStacionarni);
            this.Controls.Add(this.cmdManyToOneStacionarni);
            this.Controls.Add(this.cmdOneToManyPacijent);
            this.Controls.Add(this.cmdManyToOnePacijent);
            this.Controls.Add(this.cmdGetPacijent);
            this.Controls.Add(this.cmdCreateSubclassPacijent);
            this.Controls.Add(this.cmdTPCHPacijent);
            this.Controls.Add(this.cmdCreateNemedicinsko);
            this.Controls.Add(this.cmdCreateMedicinsko);
            this.Controls.Add(this.cmdTPCNemedicinsko);
            this.Controls.Add(this.cmdTPCMedicinsko);
            this.Controls.Add(this.cmdCreateStomatoloskaStolica);
            this.Controls.Add(this.cmdOneToManyOdeljenje);
            this.Controls.Add(this.cmdManyToOneOdeljenje);
            this.Controls.Add(this.cmdCreateSmena);
            this.Controls.Add(this.cmdReadSmena);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdReadSmena;
        private System.Windows.Forms.Button cmdCreateSmena;
        private System.Windows.Forms.Button cmdManyToOneOdeljenje;
        private System.Windows.Forms.Button cmdOneToManyOdeljenje;
        private System.Windows.Forms.Button cmdCreateStomatoloskaStolica;
        private System.Windows.Forms.Button cmdTPCMedicinsko;
        private System.Windows.Forms.Button cmdTPCNemedicinsko;
        private System.Windows.Forms.Button cmdCreateMedicinsko;
        private System.Windows.Forms.Button cmdCreateNemedicinsko;
        private System.Windows.Forms.Button cmdTPCHPacijent;
        private System.Windows.Forms.Button cmdCreateSubclassPacijent;
        private System.Windows.Forms.Button cmdGetPacijent;
        private System.Windows.Forms.Button cmdManyToOnePacijent;
        private System.Windows.Forms.Button cmdOneToManyPacijent;
        private System.Windows.Forms.Button cmdManyToOneStacionarni;
        private System.Windows.Forms.Button cmdOneToManyStacionarni;
        private System.Windows.Forms.Button cmdCreatePacijenta;
        private System.Windows.Forms.Button cmdlezina;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button smdEnumerable;
        private System.Windows.Forms.Button cmdScalar;
        private System.Windows.Forms.Button cmdMultiple;
        private System.Windows.Forms.Button cmdPaging;
        private System.Windows.Forms.Button cmdCriteria;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdTransaction;
        private System.Windows.Forms.Button cmdCreateOdrzavaHigijenuNa;
    }
}

