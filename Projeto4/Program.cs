using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimir_Valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[50];
            int i, Valor = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Write($"Inforde o {i + 1}º Valor:");
                valores[i] = int.Parse(Console.ReadLine());


                Valor = Valor + valores[1];
            }

            for (i = 0; i < 50; i++)
            {
                if (valores[i] > 50)
                {
                    Console.WriteLine($"Valor Acima de 50: {valores[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
