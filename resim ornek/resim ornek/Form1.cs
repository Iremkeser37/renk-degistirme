using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resim_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)                                                                                                  
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                ppResim.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                rbtMesaj.SelectionColor = colorDialog1.Color;
            }
            

        }
    }
}
