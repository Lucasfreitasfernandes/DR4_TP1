using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a base? ");
            string entrada_base = Console.ReadLine();

            Console.Write("Qual a altura? ");
            string entrada_altura = Console.ReadLine();

            double valorBase = double.Parse(entrada_base);
            double valorAltura = double.Parse(entrada_altura);

            Func<double, double, double> area = (b, h) => (b * h) / 2;

            double resultado = area(valorBase, valorAltura);

            Console.WriteLine($"A área do triângulo é: {resultado}");
        }
    }
}