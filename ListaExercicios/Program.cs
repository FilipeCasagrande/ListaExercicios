namespace Lista_de_Exercicios.exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region imput de dados
            decimal largura, altura, comprimento, resultado;
            Console.WriteLine("Digite o comprimento da caixa");
            comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a Largura");
            largura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            resultado = largura * altura * comprimento;

            Console.WriteLine($"o volume da caixa é {resultado}");
            Console.ReadLine();

        }
    }
}