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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal ID
        {
            get { return nmid.Value; }
            set { nmid.Value = value; }
        }
        public string Marka
        {
            get { return txtmarka.Text; }
            set { txtmarka.Text = value; }
        }

        public string Model
        {
            get { return txtmodel.Text; }
            set { txtmodel.Text = value; }
        }

        public string Yakıt
        {
            get { return txtyakıt.Text; }
            set { txtyakıt.Text = value; }
        }

        public string Motor
        {
            get { return txtmotor.Text; }
            set { txtmotor.Text = value; }
        }

        public string Renk
        {
            get { return txtrenk.Text; }
            set { txtrenk.Text = value; }
        }

        public string Yıl
        {
            get { return txtyıl.Text; }
            set { txtyıl.Text = value; }
        }

        public string Kilometre
        {
            get { return txtkm.Text; }
            set { txtkm.Text = value; }
        }

        public string Fiyat
        {
            get { return txtfiyat.Text; }
            set { txtfiyat.Text = value; }
        }

        public string İletişim
        {
            get { return mtxttel.Text; }
            set { mtxttel.Text = value; }
        }

        private void txtmarka_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtmodel_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtyakıt_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtmotor_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtrenk_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtyıl_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtkm_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void txtfiyat_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (t.Text.Trim() == "")
                errorProvider1.SetError(t, "Boş Bırakılamaz.");
            else
                errorProvider1.SetError(t, "");
        }

        private void mtxttel_Validated(object sender, EventArgs e)
        {
            var t = sender as TextBox;
            if (!mtxttel.MaskCompleted)
                errorProvider1.SetError(mtxttel, "Geçerli Telefon Girin.");
            else
                errorProvider1.SetError(mtxttel, "");

        }
    }
    
    
}
