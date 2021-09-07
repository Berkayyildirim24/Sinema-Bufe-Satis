using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satıs
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }


        int kasatutar = 0;


        private void btn1_Click(object sender, EventArgs e)
        {

            int misir, bilet, su, çay, toplam;
            misir = Convert.ToInt16(txtmisir.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            çay = Convert.ToInt16(txtcay.Text);
            toplam = misir * 4 + çay * 1 + su * 1 + bilet * 3;
            lbltoplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text=kasatutar.ToString() + "TL";


        }

        private void btn2_Click(object sender, EventArgs e)
        {

            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();


        }
    }
}
