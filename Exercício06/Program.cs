namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, peso1, nota2, peso2, notaFinal, peso;

            Console.Write("informe o valor da primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o  Peso da primeira nota: ");
            peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("informe o valor da segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o  Peso da segunda nota: ");
            peso2 = Convert.ToDecimal(Console.ReadLine());

            nota1 = nota1 * peso1;
            nota2 = nota2 * peso2;
            peso = peso1 + peso2;

            notaFinal = (nota1 + nota2) / peso;

            Console.WriteLine($"A nota final do Aluno(a) foi: {notaFinal}");
            Console.ReadLine();


        }
    }
}