using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void clear()
        {
            txtNumUm.Text = "0";
            txtNumDois.Text = "0";
            txtResultado.Text = "0";
        }

        Calculadora objC = new Calculadora();

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double numUm = double.Parse(txtNumUm.Text);
            double numDois = double.Parse(txtNumDois.Text);

            

            txtResultado.Text = objC.somar().ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double numUm = double.Parse(txtNumUm.Text);
            double numDois = double.Parse(txtNumDois.Text);



            txtResultado.Text = objC.subtrair().ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double numUm = double.Parse(txtNumUm.Text);
            double numDois = double.Parse(txtNumDois.Text);

            txtResultado.Text = objC.multiplicar().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Armazenar();

            if (objC.Getn2() != 0)
            {
                txtResultado.Text = objC.dividir().ToString();
            }
            else
            {
                MessageBox.Show("Nao e Possivel Dividir");
            }
        }

        private void Armazenar()
        {
            objC.Setn1(double.Parse(txtNumUm.Text));
            objC.Setn2(double.Parse(txtNumDois.Text));
        }
        private void btn_quantD_Click(object sender, EventArgs e)
        {

           int n = int.Parse(txtNumUm.Text);
            txtResultado.Text = objC.QuantidadedeDiv().ToString();
        }

        

        private void btnNumprimo_Click(object sender, EventArgs e)
        {
            objC.Setn1(double.Parse(txtNumUm.Text));

            if (objC.Primo())
            {
                txtResultado.Text = "E primo.";
            }else
            {
                txtResultado.Text = "Nao e primo.";
            }
        }

       



       

    }
}

