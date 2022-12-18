using System;

public class Program
{
    public static void Main(string[] args)
    {
        double raioEsfera = double.Parse(Console.ReadLine());
        double formulaVolume = (4.0 / 3) * 3.14159 * Math.Pow(raioEsfera, 3);

        Console.WriteLine($"VOLUME = {formulaVolume:F3}");
    }
}