using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[3];
            int i;
            
            
            for(i=0; i<3; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            ord(vetor1, 3);
        }

        static void ord(int[] i, int tamanhon)
        {
            int vazio, g;
            
            for(g=0; g<tamanhon; g++)
            {
                if (i[g]>i[g++])
                {
                    vazio = i[g];
                    i[g] = i[g++];
                }
            }
            Console.WriteLine("Os numeros ordenados sao: " + i[0] + "," + i[1] + "," + i[2]);
            Console.ReadLine();
        }
    }
}
