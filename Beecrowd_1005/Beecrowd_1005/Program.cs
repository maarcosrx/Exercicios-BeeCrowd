namespace Beecrowd1005
{
    public class Program
    {
       public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double Peso1 = 3.5;
            double Peso2 = 7.5;

            double MEDIA = ((A * Peso1) + (B * Peso2)) / (Peso1 + Peso2);

            Console.WriteLine($"MEDIA = {MEDIA:F5}");
        }
    }
}