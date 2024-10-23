using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {



            string estado ;

            double valor_carro, imposto;

            valor_carro = double.Parse(txt_Valor.Text);

            estado = cmb_Estado.Text;

            if(rdb_Passeio.Checked)
            {
                if (estado == "AC" || estado == "ES" || estado == "TO" || estado == "SC")
                {
                    imposto = valor_carro * 0.02;
                }
                else if (estado == "DF" || estado == "MG" || estado == "PR" || estado == "GO" || estado == "RJ" || estado == "SP")
                {
                    imposto = valor_carro * 0.04;
                }
                else
                {
                    imposto = valor_carro * 0.03;
                }
                MessageBox.Show("O valor do IPVA e:" + imposto.ToString());
            }

            if (rdb_Caminhonete.Checked)
            {
                if (estado == "AC" || estado=="DF")
                {
                    imposto = valor_carro * 0.01;
                }
                else if (estado=="PR"||estado=="MS")
                {
                    imposto = valor_carro * 0.04;
                }
                else if (estado == "ES" || estado == "RR" || estado == "SC" || estado == "SP")
                {
                    imposto = valor_carro * 0.02;
                }
                else
                {
                    imposto = valor_carro * 0.03;
                }

                MessageBox.Show("O valor do IPVA e:" + imposto.ToString());
            }

            if (rdb_Moto.Checked)
            {
                if (estado == "AL" || estado == "BA" || estado == "BO"||estado=="PB")
                {
                    imposto = valor_carro * 0.03;
                }
                else if (estado == "AC" || estado == "ES"|| estado=="MA"||estado=="MT"||estado=="PA"||estado=="SC")
                {
                    imposto = valor_carro * 0.01;
                }
                else
                {
                    imposto = valor_carro * 0.02;
                }
                MessageBox.Show("O valor do IPVA e:" + imposto.ToString());
            }
        }
    }
}
