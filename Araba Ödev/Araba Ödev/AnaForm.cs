using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Ödev
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void arabaekle(object sender, EventArgs e)
        {
            f araba = new frmaraba() { Text = "Araba Ekle", StartPosition = FormStartPosition.CenterParent };

            if (araba.ShowDialog() != DialogResult.OK)
                return;

            ListViewItem arac = new ListViewItem(new string[]{
                araba.ID.ToString(),
                araba.Marka,
                araba.Model,
                araba.Yakıt,
                araba.Motor,
                araba.Renk,
                araba.Yıl,
                araba.Kilometre,
                araba.Fiyat,
                araba.İletişim
            });
            listView1.Items.Add(arac);
        }

        private void arabadüzenle(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem arac = listView1.SelectedItems[0];

            frmaraba araba = new frmaraba()
            {
                Text = "Araba Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                ID=decimal.Parse(arac.SubItems[0].Text),
                Marka=arac.SubItems[1].Text,
                Model = arac.SubItems[2].Text,
                Yakıt = arac.SubItems[3].Text,
                Motor = arac.SubItems[4].Text,
                Renk = arac.SubItems[5].Text,
                Yıl = arac.SubItems[6].Text,
                Kilometre = arac.SubItems[7].Text,
                Fiyat = arac.SubItems[8].Text,
                İletişim = arac.SubItems[9].Text,
            };

            if (araba.ShowDialog() != DialogResult.OK)
                return;
            arac.SubItems[0].Text = araba.ID.ToString();
            arac.SubItems[1].Text = araba.Marka;
            arac.SubItems[2].Text = araba.Model;
            arac.SubItems[3].Text = araba.Yakıt;
            arac.SubItems[4].Text = araba.Motor;
            arac.SubItems[5].Text = araba.Renk;
            arac.SubItems[6].Text = araba.Yıl;
            arac.SubItems[7].Text = araba.Kilometre;
            arac.SubItems[8].Text = araba.Fiyat;
            arac.SubItems[9].Text = araba.İletişim;
        }

        private void arabasil(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem arac = listView1.SelectedItems[0];
            listView1.Items.Remove(arac);
        }
    }
}
