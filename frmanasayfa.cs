using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            frmogrenci ogrenci = new  frmogrenci();
            ogrenci.ShowDialog();
        
        }

        private void btntur_Click(object sender, EventArgs e)
        {
            frmtur tur = new frmtur();
            tur.ShowDialog();
        }

        private void btnodunckıtap_Click(object sender, EventArgs e)
        {
            frmodunc odunc = new frmodunc();
            odunc.ShowDialog();
        }

        private void btnkitapişleri_Click(object sender, EventArgs e)
        {
            frmkitap kitap = new frmkitap();
            kitap.ShowDialog();
        }
    }
}
