namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, f = 32, conversao;

            Console.Write("informe a temperatura em Celsius para a convesão: ");
            c = Convert.ToInt32(Console.ReadLine());

            conversao = c * 9 / 5 + 32;

            Console.WriteLine($"O valor da temperatura na escala Fahrenheit é {conversao}ºF");
            Console.ReadLine();
        }
    }
}