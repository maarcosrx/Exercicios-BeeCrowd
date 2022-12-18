namespace Beecrowd1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n / 60;
            double hora = n % 60;
            
            Console.WriteLine($"{n:#.##}:{hora:#.##}");

        }
    }
    
}