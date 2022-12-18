using System.Formats.Asn1;

namespace Beecrowd1002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double A = 3.14159 * Math.Pow(r, 2);
            Console.WriteLine($"A={A:F4}");
       
        }
    }
}