namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double raiz = 0;
            Console.WriteLine("Informe o número para ver se ele é um número primo");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine($"O número {numero} não é um número primo");
            }

            for (int i = 2; i < numero; i++)
            {
                if (raiz % i != 0)
                {

                    Console.WriteLine("O número não é primo");
                }

                else
                {
                    Console.WriteLine($"O número é primo");
                }

                Console.ReadLine();
            }

        }
    }
}