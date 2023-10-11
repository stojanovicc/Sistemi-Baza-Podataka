﻿using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.Forme
{
    public partial class DodajOsobljeNemedicinskoForma : Form
    {
        NemedicinskoBasic nemedicinsko;
        public DodajOsobljeNemedicinskoForma()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NemedicinskoBasic v = new NemedicinskoBasic();

            v.Ime = txtIme.Text;
            v.Prezime = txtPrezime.Text;
            v.TipOdrzavanja = txtTipOdrzavanja.Text;
            v.Struka = txbStruka.Text;

            DTOManager.sacuvajNemedicinsko(v);
            MessageBox.Show("Uspesno ste dodali nemedicinsko osoblje!");
            this.Close();
        }
    }
}
