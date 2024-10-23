using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01pag81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 4];



            Random objN = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = i * j;
                }
            }


            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }

                Console.Write("\n");
            }

            Console.ReadKey();



        }
    }
}
