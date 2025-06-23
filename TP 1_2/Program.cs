using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("(1) Inglês");
            Console.WriteLine("(2) Português");
            Console.WriteLine("(3) Espanhol");

            string idioma = Console.ReadLine();

            Action<string> Exibir_mensagem;

            if (idioma == "1")
            {
                Exibir_mensagem = mensagem => Console.WriteLine("Welcome!");
            }
            else if (idioma == "2")
            {
                Exibir_mensagem = mensagem => Console.WriteLine("Seja bem-vindo!");
            }
            else if (idioma == "3")
            {
                Exibir_mensagem = mensagem => Console.WriteLine("¡Bienvenidos!");
            }
            else
            {
                Exibir_mensagem = mensagem => Console.WriteLine("Idioma não reconhecido.");
            }

            Exibir_mensagem(null);
        }
    }
}
