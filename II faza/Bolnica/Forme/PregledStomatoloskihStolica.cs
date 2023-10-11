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
    public partial class PregledStomatoloskihStolica : Form
    {
        Stomatoloska_stolicaBasic stolica;
        NemedicinskoBasic nemedicinsko;
        public PregledStomatoloskihStolica()
        {
            InitializeComponent();
        }
        public PregledStomatoloskihStolica(Stomatoloska_stolicaBasic p)
        {
            InitializeComponent();
            stolica = p;
        }
        public PregledStomatoloskihStolica(NemedicinskoBasic p)
        {
            InitializeComponent();
            nemedicinsko = p;
        }

        private void buttonDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajStomatoloskuStolicu formaDodaj = new DodajStomatoloskuStolicu();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void OdeljenjaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            stolice.Items.Clear();
            List<StomatoloskaStolicaPregled> podaci = DTOManager.vratiStomatoloskeStolice();

            foreach (StomatoloskaStolicaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Proizvodjac, p.Datum_proizvodnje.ToString() });
                this.stolice.Items.Add(item);
            }

            this.stolice.Refresh();
        }
        private void buttonIzmeniOdeljenje_Click(object sender, EventArgs e)
        {
            if (stolice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stomatolosku stolicu cije podatke zelite da izmenite!");
                return;
            }

            string proizvodjac = stolice.SelectedItems[0].SubItems[0].Text;
            Stomatoloska_stolicaBasic ob = DTOManager.vratiStomatoloskuStolicu(proizvodjac);

            IzmeniStomatoloskuStolicu formaUpdate = new IzmeniStomatoloskuStolicu(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void buttonObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            if (stolice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje koju zelite da obrisete!");
                return;
            }

            string id = stolice.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranu stomatolosku stolicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStomatoloskuStolicu(id);
                MessageBox.Show("Brisanje stomatoloske stolice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
