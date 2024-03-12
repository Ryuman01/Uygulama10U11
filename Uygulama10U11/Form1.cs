using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Uygulama10U11
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            foreach (string sehir in sehirler)
            {
                lbListe.Items.Clear();
                lbListe.Items.Add(sehir);
            }
        }
    }
}
