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
    public partial class PregledNemedicinskogOsoblja : Form
    {
        OdeljenjeBasic od;
        public PregledNemedicinskogOsoblja()
        {
            InitializeComponent();
        }
        public PregledNemedicinskogOsoblja(OdeljenjeBasic p)
        {
            InitializeComponent();
            od = p;
        }

        private void PregledNemedicinskogOsoblja_Load(object sender, EventArgs e)
        {
             popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajOsobljeNemedicinskoForma formaDodaj = new DodajOsobljeNemedicinskoForma();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }
        public void popuniPodacima()
        {
            nemedicinsko.Items.Clear();
            List<NemedicinskoPregled> podaci = DTOManager.vratiNemedicinsko();

            foreach (NemedicinskoPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {p.Mar_br.ToString(), p.Ime,p.Prezime, p.TipOdrzavanja, p.Struka});
                nemedicinsko.Items.Add(item);

            }
            nemedicinsko.Refresh();
        }

        private void nemedicinsko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nemedicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(nemedicinsko.SelectedItems[0].SubItems[0].Text);
            NemedicinskoBasic ob = DTOManager.vratiNemedicinsko(id);

            IzmeniOsobljeNemedicinskoForma formaUpdate = new IzmeniOsobljeNemedicinskoForma(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nemedicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu koju zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(nemedicinsko.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu osobu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOsobljeIzSistema(id);
                MessageBox.Show("Brisanjeosobe je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nemedicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite HIGIJENICARA koga zelite da dodate odeljenju!");
                return;
            }

            int id = Int32.Parse(nemedicinsko.SelectedItems[0].SubItems[0].Text);
            NemedicinskoBasic p = DTOManager.vratiNemedicinsko(id);
            PregledOdeljenjaZaOdrzavanje forma = new PregledOdeljenjaZaOdrzavanje(p);
            forma.ShowDialog();
        }
        //stolice
        private void button5_Click(object sender, EventArgs e)
        {
            if (nemedicinsko.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite TEHNICARA kojem zelite da dodelite stomatolosku stolicu!");
                return;
            }

            int id = Int32.Parse(nemedicinsko.SelectedItems[0].SubItems[0].Text);
            NemedicinskoBasic p = DTOManager.vratiNemedicinsko(id);
            PregledStomatoloskihStolica forma = new PregledStomatoloskihStolica(p);
            forma.ShowDialog();

        }

    }
}
