﻿namespace Beecrowd1018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double N, nota100, nota50, nota20, nota10, nota5, nota2, nota1, moeda1, moeda050, moeda025, moeda010, moeda005, moeda001, resto;
                N = double.Parse(Console.ReadLine());

            nota100 = N / 100;
            resto = N % 100;

            nota50 = resto / 50;
            resto= resto % 50;

            nota20 = resto / 20;
            resto= resto % 20;

            nota10 = resto / 10;
            resto = resto % 10;

            nota5 = resto / 5;
            resto = resto % 5;

            nota2 = resto / 2;
            resto = resto % 2;

            moeda1 = resto / 1;
            resto = resto % 1;

            Console.WriteLine(N);
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1,00");
            
        }
    }
}