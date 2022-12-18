namespace Beecrowd1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double PesoA = 2;
            double PesoB = 3;
            double PesoC = 5;
            double MEDIA = ((A * PesoA) + (B * PesoB) + (C * PesoC)) / (PesoA + PesoB + PesoC);

            Console.WriteLine($"MEDIA = {MEDIA:F1}");
        }
    }
}