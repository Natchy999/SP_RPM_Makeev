using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LB_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            Console.WriteLine($"Все запущенные процессы на компьютере ({processes.Count()}):");
            foreach (Process process in processes)
            {
                Console.WriteLine($"ID: {process.Id} | Имя: {process.ProcessName}");
            }

            Console.WriteLine("\nДля продолжения нажмите любую клавишу..."); Console.ReadKey();
            
            Process vsproc = Process.GetProcessesByName("devenv")[0];
            ProcessThreadCollection vsprocThreads = vsproc.Threads;
            Console.WriteLine($"\nВсе потоки процесса Visual Studio ({vsprocThreads.Count})");
            foreach (ProcessThread procThread in vsprocThreads)
            {
                Console.WriteLine($"ThreadID: {procThread.Id}");
            }

            Console.WriteLine("\nДля продолжения нажмите любую клавишу..."); Console.ReadKey();

            Console.WriteLine("\nЗапуск процесса mspaint.exe");
            Process.Start("mspaint.exe");
            Console.WriteLine("\nЗапуск процесса msedge.exe");
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");

            Console.WriteLine("\nДля продолжения нажмите любую клавишу..."); Console.ReadKey();
        }
    }
}
