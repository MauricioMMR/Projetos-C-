using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material
{
    internal class Calculadora

    {
       



        private double n1, n2;

        public void Setn1(double N1)
        {
            this.n1 = N1;
        }

        public Double Getn1()
        {
            return this.n1;
        }

        public void Setn2(double N2)
        {
             this.n2 = N2;
        }

        public Double Getn2()
        {
            return this.n2;
        }


        public double somar()
        {
            return this.n1 + this.n2;
        }
        public double subtrair()
        {
            return this.n1 - this.n2;
        }
        public double multiplicar()
        {
            return this.n1 * this.n2;
        }
        public double dividir()
        {
            return this.n1 / this.n2;
        }

        public bool Primo()
        {
            if (QuantidadedeDiv() == 2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public int QuantidadedeDiv()
        {
            int cont = 0, i;

            for (i = 1; i <= this.n1; i++)
            {
                if (this.n1 % i == 0)
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}
