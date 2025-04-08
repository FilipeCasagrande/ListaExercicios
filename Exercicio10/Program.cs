namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, condicao;

            Console.Write("Informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            condicao = peso / (altura * altura);
            string resultado = condicao.ToString("F2");

            Console.WriteLine($"O resultado do IMC é: {resultado}");
            Console.WriteLine("-----------------------------------------------------");

            if (condicao <= 18.5)
            {
                Console.WriteLine("A pessoa está abaixo do peso ");
            }

            else if (condicao > 18.5 && condicao <= 25)
            {
                Console.WriteLine("A pessao está com o peso normal");
            }

            else if (condicao > 25 && condicao < 30)
            {
                Console.WriteLine("a pessao esta acima do peso");
            }

            else if (condicao > 30)
            {
                Console.WriteLine("A pessoa está obesa");
            }

            Console.ReadLine();
        }
    }
}