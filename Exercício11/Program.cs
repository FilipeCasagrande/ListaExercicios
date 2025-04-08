namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numero;
            Console.Write("informe um número para saber se ele é Par ou Impar: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"o número {numero} é Par");
            }
            else if (numero % 2 != 0)
            {
                Console.WriteLine($"O número {numero} é Impar");
            }
            Console.ReadLine();

        }
    }
}