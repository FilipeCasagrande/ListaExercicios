namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase, vendas, comissao, salarioFinal;

            Console.WriteLine("informe o valor do salário do vendedor");
            salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Infomre o valor total das vendas do vendedor");
            vendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe o valor da comissão do vendedor");
            comissao = Convert.ToDecimal(Console.ReadLine());

            salarioFinal = vendas * comissao / 100;
            salarioBase = salarioBase + salarioFinal;
            Console.WriteLine($"O valor da comissão é {salarioFinal}");
            Console.WriteLine($"o valor total do salário do vendedor é {salarioBase}");
            Console.ReadLine();
        }
    }
}