namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fim, num1 = 0, num2 = 1, num3;

            Console.WriteLine("Informe um número para terminar a sequenacia de Fibonacci");
            fim = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{num1}, ");
            Console.Write($"{num2}, ");

            for (int i = 0; i <= fim; i++)
            {
                num3 = num1 + num2;
                Console.Write($"{num3}, ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();
        }
    }
}