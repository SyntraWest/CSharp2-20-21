using System;
using System.Diagnostics;

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

            var startinfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = @"C:\Users\pvoos\AppData\Local\Temp\hallo.txt",
            };

            Process.Start(startinfo);

        }
    }
}
