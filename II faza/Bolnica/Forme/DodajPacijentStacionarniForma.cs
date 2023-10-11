using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Bolnica.Forme
{
    public partial class DodajPacijentStacionarniForma : Form
    {
        PacijentBasic pacijent;
        public DodajPacijentStacionarniForma()
        {
            InitializeComponent();
        }
        private void DodajPacijentStacionarniForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StacionarniBasic o = new StacionarniBasic();
            o.Ime = txtIme.Text;
            o.Prezime = txtPrezime.Text;
            o.Datum_prijema = datePrijema.Value;
            o.Datum_otpusta = dateOtpusta.Value;

            DTOManager.sacuvajStacionarni(o);
            MessageBox.Show("Uspesno ste dodali novog stacionarnog pacijenta!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
