using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string> logActions = null;

            logActions += logger.LogToFile;

            string mensagem = "Sistema iniciado com sucesso.";


            logActions?.Invoke(mensagem);

            Console.WriteLine("Fim do programa.");
        }

        class Logger
        {
            public void LogToConsole(string mensagem)
            {
                Console.WriteLine($"[Console] {mensagem}");
            }
            public void LogToFile(string mensagem)
            {
                Console.WriteLine($"[Arquivo] {mensagem} (simulado)");
            }
            public void LogToDatabase(string mensagem)
            {
                Console.WriteLine($"[Banco de Dados] {mensagem} (simulado)");
            }
        }
    }
}
