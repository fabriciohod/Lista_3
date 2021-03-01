using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = string.Format(Console.ReadLine());

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 10)
            {
                Console.WriteLine(nome + " pertence a categoria Infantil");
                Console.ReadLine();
            }
            if (idade >= 11 && idade <= 15)
            {
                Console.WriteLine(nome + " pertence a categoria Juvenil");
                Console.ReadLine();
            }
            if (idade >= 16 && idade <= 20)
            {
                Console.WriteLine(nome + " pertence a categoria Junior");
                Console.ReadLine();
            }
            if (idade >= 21 && idade <= 25)
            {
                Console.WriteLine(nome + " pertence a categoria Profissional");
                Console.ReadLine();
            }
        }
    }
}
