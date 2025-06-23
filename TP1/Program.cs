using System;

namespace tp1
{
    class Program
    {

        public delegate void CalculateDiscount(double preco);

        static void Main(string[] args)
        {
            Console.Write("Digite o preço original do produto: ");
            string preco_original = Console.ReadLine();

            if (double.TryParse(preco_original, out double preco))
            {

                CalculateDiscount calcular_desconto = AplicarDesconto;
                calcular_desconto(preco);
            }
            else
            {
                Console.WriteLine("Preço inválido!");
            }
        }

        public static void AplicarDesconto(double preco)
        {
            double desconto = preco * 0.10;
            double precoFinal = preco - desconto;
            Console.WriteLine($"Preço com desconto de 10%: R$ {precoFinal}");
        }
    }
}
