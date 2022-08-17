using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17__entre_10_e_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, contador;
        private void btnResultado_Click(object sender, EventArgs e)
        {
          n1 = double.Parse(txtNumero.Text);
            
            if(n1 >= 10 && n1<=150)
            {
                contador = contador + 1;
                txtResultado.Text = contador.ToString();
            }
            else
            {
                txtNumero.Text = "";
                MessageBox.Show("Este número não está entre 10 e 150");
            }


        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
