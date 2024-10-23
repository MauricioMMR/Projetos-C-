using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMedida_Click(object sender, EventArgs e)
        {
            double A, B, C;

            A = double.Parse(txtA.Text);
            B = double.Parse(txtB.Text);
            C = double.Parse(txtC.Text);

            if (A != B && A != C && C != B)
            {
                MessageBox.Show("E um triangulo Escaleno");
            }
            if (A == B && B == C)
            {
                MessageBox.Show("E um triangulo Equílatero");
            }
            if (A == B && B != C)
            {
                MessageBox.Show("E um triangulo Isósceles");
            }

        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            double anguloA, anguloB, anguloC;

            anguloA = double.Parse(txtAnguloA.Text);
            anguloB = double.Parse(txtAnguloB.Text);
            anguloC = double.Parse(txtAnguloC.Text);

            if (anguloA == 90 || anguloB == 90 || anguloC == 90) 
            {
                MessageBox.Show("Esse e um Retangulo");
            }
            if (anguloA < 90 && anguloB < 90 && anguloC < 90)
            {
                MessageBox.Show("Esse e um Acutangulo");
            }
            if (anguloA > 90 || anguloB > 90 || anguloC > 90)
            {
                MessageBox.Show("Esse e um Obtusangulo");
            }

        }
    }
}
