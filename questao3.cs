using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da Base do retangulo: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Altura do retangulo: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("A area do retangulo e " + (b * a));
            Console.WriteLine("O Perimetro do retangulo e " + (2 / (b + a)));
            Console.ReadLine();


        }
    }
}
