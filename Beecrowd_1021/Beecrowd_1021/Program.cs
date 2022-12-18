namespace Beecrowd102 {
    public class Program {
        public static void Main(string[] args) {

            double nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda050, moeda025, moeda010, moeda005, moeda001, resto;
            double n = double.Parse(Console.ReadLine());

            nota100 = (int)(n / 100);
            n -= 100 * nota100;

            nota50 = (int)n / 50;
            n -= 50 * nota50;

            nota20 = (int)n / 20;
            n -= 20 * nota20;

            nota10 = (int)n / 10;
            n -= 10 * nota10;

            nota5 = (int)n / 5;
            n -= 5 * nota5;

            nota2 = (int)n / 2;
            n -= 2 * nota2;

            n *= 100; 
            moeda001 = (int)n / 100;
            n -= 100 * moeda001;
            
            moeda050 = (int)n / 50;
            n -= 50 * moeda050;

            moeda025 = (int)n / 25;
            n -= 25 * moeda025;

            moeda010 = (int)n / 10;
            n -= 10 * moeda010;
            
            moeda005 = (int)n / 5;
            n -= 5 * moeda005;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda001} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda050} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda025} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda010} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda005} moeda(s) de R$ 0.05");
            Console.WriteLine($"{n:F0} moeda(s) de R$ 0.01");


        }
    }
}