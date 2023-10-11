using Bolnica.Entiteti;
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
    public partial class DodajOsobljeMedicinskoForma : Form
    {
        MedicinskoBasic medicinsko;
        public DodajOsobljeMedicinskoForma()
        {
            InitializeComponent();
        }
        private void DodajOsobljeMedicinskoForma_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MedicinskoBasic v = new MedicinskoBasic();
            v.Ime = txtIme.Text;
            v.Prezime = txtPrezime.Text;
            v.TipLekara = txtTipLekara.Text;
            v.Radni_staz = (int)radniStaz.Value;
            v.BrOrdinacije = (int)brojOrdinacije.Value;
            v.Specijalnost = txbSpecijalnost.Text;

            DTOManager.sacuvajMedicinsko(v);
            MessageBox.Show("Uspesno ste dodali medicinsko osoblje!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
