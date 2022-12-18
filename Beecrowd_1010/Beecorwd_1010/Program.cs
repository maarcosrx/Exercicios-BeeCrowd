namespace Beecrowd_1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(' ');

            double valorTotal1 = int.Parse(dados1[1]) * double.Parse(dados1[2]);
            double valorTotal2 = int.Parse(dados2[1]) * double.Parse(dados2[2]);
            double valorTotalFinal = valorTotal1 + valorTotal2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalFinal:F2}");

        }
    }
}