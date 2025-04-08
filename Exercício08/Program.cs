namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, resultado;

            Console.WriteLine($"Informe valor de A");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe o valor de B");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe o valor de C");
            num3 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            if (resultado < num3)
            {
                Console.WriteLine("Os valores de A + B juntos são menores que C");
            }
            else
            {
                Console.WriteLine("O valor de C e menor que A + B juntos");
            }
            Console.ReadLine();
        }


    }
}