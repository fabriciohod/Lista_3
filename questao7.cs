using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{

    namespace ConsoleApp2
    {
        class Program
        {
            static void Main(string[] args)
            {
                float vazio;

                Console.WriteLine("Digite um numero:");
                float n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro numero:");
                float n2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a operaco + ; - ; * ; /");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine("A soma dos valoeres e " + (n1 + n2));
                        Console.ReadLine();
                        break;

                    case "-":
                        Console.WriteLine("A subtracao dos valores e " + (n1 - n2));
                        Console.ReadLine();
                        break;

                    case "*":
                        Console.WriteLine("A multiplicao dos valores e " + (n1 * n2));
                        Console.ReadLine();
                        break;

                    case "/":
                        Console.WriteLine("A divisao dos valores e " + (n1 / n2));
                        Console.ReadLine();
                        break;

                }

            }
        }
    }
}
