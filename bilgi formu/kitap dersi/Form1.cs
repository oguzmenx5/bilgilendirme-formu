using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_dersi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_ad.Text = tb_ad.Text;
            lb_soyad.Text = tb_soyad.Text;
            lb_yaş.Text = tb_yaş.Text;
            lb_meslek.Text = tb_meslek.Text;
            lb_posta.Text = tb_eposta.Text;
            lb_araba.Text = tb_araba.Text;



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)

            {
                btn_tıklayın.PerformClick();
            }
        }
    }
}
