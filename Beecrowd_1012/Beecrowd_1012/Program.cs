namespace Beecrowd1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');

            double formulaAreaTriangulo = double.Parse(dados[0]) * double.Parse(dados[2]);
            double areaTriangulo = formulaAreaTriangulo / 2;

            double areaCirculo = 3.14159 * (double.Parse(dados[2]) * double.Parse(dados[2]));

            double areaTrapezio = (double.Parse(dados[0]) + double.Parse(dados[1])) * double.Parse(dados[2]) / 2;

            double areaQuadrado = double.Parse(dados[1]) * double.Parse(dados[1]);

            double areaRetangulo = double.Parse(dados[0]) * double.Parse(dados[1]);

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
        }
    }
}