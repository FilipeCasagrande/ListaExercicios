namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 5;
            int[] numero = new int[tam];
            int cont = 0;

            {
                for (int i = 0; i < tam; i++)
                {
                    Console.WriteLine("Informe um numero");
                    numero[cont] = Convert.ToInt32(Console.ReadLine());
                    cont++;

                    if (cont == tam)
                    {
                        break;
                    }
                }

                Array.Sort(numero);
                Array.Reverse(numero);

                Console.WriteLine("Os numeros da lista em forma decrescente são:");

                foreach (int numeros in numero)
                {
                    Console.WriteLine($"numero: {numeros}");
                }
                Console.ReadLine();
            }
        }
    }
}