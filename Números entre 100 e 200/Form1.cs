using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15__Entre_100_e_200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double n1;

            n1 = double.Parse(txtNumero.Text);

            if (n1 > 100 && n1 < 200)
            {
                txtResposta.Text = "Este Número está entra 100 e 200";
            }
            else
            {
                txtResposta.Text = "Este número não está entre 100 e 200";
            }
        }
    }
}
