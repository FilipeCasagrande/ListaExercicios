namespace exercicio13
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int contador, resultado = 1;
            Console.WriteLine("Informe o valor de A para imprimir a sequência");
            contador = Convert.ToInt32(Console.ReadLine());

            for (int i = contador; i >= 1; i--)
            {
                if (i != contador)
                {
                    Console.Write($" X ");
                }
                Console.Write(i);
                resultado *= i;
            }
            Console.WriteLine($" = {resultado}");
            Console.ReadLine();
        }
    }
}