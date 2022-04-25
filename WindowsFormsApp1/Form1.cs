using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKntrl_Click(object sender, EventArgs e)
        {
            ServiceReference1.KPSPublicSoapClient kPS = new ServiceReference1.KPSPublicSoapClient();
         bool kotrol=kPS.TCKimlikNoDogrula(long.Parse(txtTc.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), int.Parse(txtYil.Text));

            if(kotrol)
            {
                MessageBox.Show("bilgileriniz dogrulandi");
            }
            else
            {
                MessageBox.Show("bilgileriniz dogrulanamadi");
            }
        }
    }
}
