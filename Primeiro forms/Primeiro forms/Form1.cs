using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomaTudo_click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);

            MessageBox.Show($"{numero1 + numero2}");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);

            MessageBox.Show($"{numero1 / numero2}");
        }

        private void btnSubtracao_click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);

            MessageBox.Show($"{numero1 - numero2}");
        }

        private void btnMultiplicacao_click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);

            MessageBox.Show($"{numero1 * numero2}");
        }

        private void txtnumero2_Leave(object sender, EventArgs e)
        {

        }
    }
}
