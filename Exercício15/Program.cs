using System.ComponentModel.Design;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.WriteLine("Precione ENTER para gerar os numeros de 1 a 100");
            Console.ReadLine();

            while (numero != 101)
            {
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (numero % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                else if (numero % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }

                else
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.ReadLine();
        }
    }
}