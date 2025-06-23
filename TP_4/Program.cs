using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a temperatura do sistema? ");
            string entrada_base = Console.ReadLine();

            if (double.TryParse(entrada_base, out double temperatura))
            {
                TemperatureSensor sensor = new TemperatureSensor();

                sensor.TemperaturaAlta += AvisoTemperaturaAlta;

                sensor.VerificarTemperatura(temperatura);
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        static void AvisoTemperaturaAlta(object sender, double temperatura)
        {
            Console.WriteLine($"[ALERTA] Temperatura alta detectada: {temperatura}°C");
        }

        class TemperatureSensor
        {
            public delegate void TemperatureExceeded(object sender, double temperatura);
            public event TemperatureExceeded TemperaturaAlta;

            private const double Limite = 100.0;

            public void VerificarTemperatura(double temperaturaAtual)
            {
                Console.WriteLine($"Temperatura lida: {temperaturaAtual}°C");

                if (temperaturaAtual >= Limite)
                {

                    TemperaturaAlta?.Invoke(this, temperaturaAtual);
                }
                else
                {
                    Console.WriteLine("Temperatura dentro dos limites normais.");
                }
            }
        }
    }
}
