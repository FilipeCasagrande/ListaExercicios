namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 101;

            Console.WriteLine("Aperte ENTER para escrever os números impares de 100 a 200");
            Console.ReadLine();

            while (true)
            {
                if (numero < 200)
                {
                    Console.WriteLine("Número:" + numero);
                    numero = numero + 2;
                }

                else if (numero >= 200)
                {
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}