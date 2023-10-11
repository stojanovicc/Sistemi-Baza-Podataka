using Bolnica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolnica.Forme
{
    public partial class IzmeniOsobljeNemedicinskoForma : Form
    {
        NemedicinskoBasic nemedicinsko;

        public IzmeniOsobljeNemedicinskoForma()
        {
            InitializeComponent();
        }
        public IzmeniOsobljeNemedicinskoForma(NemedicinskoBasic dl)
        {
            InitializeComponent();
            nemedicinsko = dl;
        }
        private void IzmeniOsobljeNemedicinskoForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtIme.Text = nemedicinsko.Ime;
            txtPrezime.Text = nemedicinsko.Prezime;
            txtTipOdrzavanja.Text = nemedicinsko.TipOdrzavanja;
            txbStruka.Text = nemedicinsko.Struka;
        }
    }
}
