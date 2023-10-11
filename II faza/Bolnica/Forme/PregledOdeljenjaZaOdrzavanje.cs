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
    public partial class PregledOdeljenjaZaOdrzavanje : Form
    {
        OdeljenjeBasic odeljenje;
        NemedicinskoBasic nemedicinsko;
        public PregledOdeljenjaZaOdrzavanje()
        {
            InitializeComponent();
        }

        private void PregledOdeljenjaZaOdrzavanje_Load(object sender, EventArgs e)
        {

        }
        public PregledOdeljenjaZaOdrzavanje(OdeljenjeBasic p)
        {
            InitializeComponent();
            odeljenje = p;
        }
        public PregledOdeljenjaZaOdrzavanje(NemedicinskoBasic p)
        {
            InitializeComponent();
            nemedicinsko = p;
        }
        public void popuniPodacima()
        {
            odeljenja.Items.Clear();
            List<OdrzavaHigijenuNaBasic> podaci = DTOManager.vratiSveOdrzavaHigijenu(nemedicinsko.Mat_br);

            foreach (OdrzavaHigijenuNaBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Matbr.ToString(), p.HigijenicarOdrzava.ToString(), p.OdrzavaOdeljenje.ToString(), p.Vreme_odrzavanja.ToString() });
                odeljenja.Items.Add(item);
            }

            odeljenja.Refresh();
        }


        private void buttonDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajOdeljenje formaDodaj = new DodajOdeljenje();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void buttonIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            if (odeljenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(odeljenja.SelectedItems[0].SubItems[0].Text);
            OdeljenjeBasic ob = DTOManager.vratiOdeljenja(id);

            IzmeniOdeljenje formaUpdate = new IzmeniOdeljenje(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void buttonObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            if (odeljenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje koju zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(odeljenja.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano odeljenje?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOdeljenje(id);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
