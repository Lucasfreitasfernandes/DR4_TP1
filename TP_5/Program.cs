using System;
using System.Threading;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadManager p = new DownloadManager();
            p.DownloadFinalizado += (s, e) => Console.WriteLine("Download Finalizado.");
            p.Executar();
        }
        class DownloadManager
        {
            public event EventHandler DownloadFinalizado;

            public void Executar()
            {
                Console.WriteLine("Download iniciado...");
                Thread.Sleep(1000);
                DownloadFinalizado?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
