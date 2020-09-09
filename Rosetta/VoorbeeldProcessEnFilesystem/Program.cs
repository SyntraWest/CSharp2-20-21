using System;
using System.Diagnostics;
using System.IO;

namespace VoorbeeldProcessEnFilesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // lijst van alle procesnamen
            //var processes = Process.GetProcesses();
            //foreach (var proc in processes)
            //{
            //    Console.WriteLine(proc.ProcessName);
            //}

            string pad = @"C:\Users\pvoos\AppData\Local\Temp\hallo.txt";

            var startinfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = pad,
            };

            Process.Start(startinfo);

            Console.WriteLine("Inhoud van het bestand:");
            string inhoud = File.ReadAllText(pad);

            Console.WriteLine(inhoud);

            File.WriteAllText(pad, "Hallo\n");
            File.AppendAllText(pad, "Ook hallo");
            // inhoud van het bestand is nu gewijzigd


            // Interessant voor volgende les (14/9):
            // Volgende zijn beiden TextReaders:
            // Console.In
            // File.OpenText(pad)

        }
    }
}
