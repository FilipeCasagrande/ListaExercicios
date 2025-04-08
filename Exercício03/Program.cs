namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal kmInicial, kmFinal, consumo, distancia, consumoKm;


            Console.WriteLine("Infome o Km inicial");
            kmInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Infome o Km final");
            kmFinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("infome a quantidade combustivel abastecido");
            consumo = Convert.ToDecimal(Console.ReadLine());

            distancia = kmFinal - kmInicial;

            consumoKm = distancia / consumo;
            consumoKm = Math.Round(consumoKm, 2);

            Console.WriteLine($"Foram gastos: {consumoKm} Litros de combustivel ");
            Console.ReadLine();
        }
    }
}