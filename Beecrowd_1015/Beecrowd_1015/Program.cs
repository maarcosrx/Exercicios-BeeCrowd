namespace Beecrowd1015
{
    public class Program
    {
        public static void Main()
        {
            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(' ');

            double x2x1 = double.Parse(dados2[0]) - double.Parse(dados1[0]);
            double y2y1 = double.Parse(dados2[1]) - double.Parse(dados1[1]);
                        
            double problema1 = Math.Pow(x2x1, 2);
            double problema2 = Math.Pow(y2y1, 2);

            double distancia = Math.Sqrt(problema1 + problema2);

            Console.WriteLine($"{distancia:F4}");  
        }
    }
}