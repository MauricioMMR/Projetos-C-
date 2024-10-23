using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, contCandA = 0, contCandB = 0, contCandC = 0, contCandD = 0;
            


            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Escolha em quem deseja votar: ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1 - Candidato A");
            Console.WriteLine("2 - Candidato B");
            Console.WriteLine("3 - Candidato C");
            Console.WriteLine("4 - Candidato D");
            Console.WriteLine("-------------------------------------------------------");
            voto = int.Parse(Console.ReadLine());
            while (voto != 0)
            {




                switch (voto)
                {
                    case 1: contCandA++; break;
                    case 2: contCandB++; break;
                    case 3: contCandC++; break;
                    case 4: contCandD++; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Não foi informado um voto válido. ");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }


                Console.WriteLine("Vote digitando 1, 2, 3 ou 4: ");


                voto = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");


                
                
            }

            Console.Clear();

            Console.WriteLine("Quantidade de votos do cantidato A:" + contCandA + " Votos");
            Console.WriteLine("Quantidade de votos do cantidato B:" + contCandB + " Votos");
            Console.WriteLine("Quantidade de votos do cantidato C:" + contCandC + " Votos");
            Console.WriteLine("Quantidade de votos do cantidato D:" + contCandD + " Votos");

            Console.ReadKey();



        }
    }
}

