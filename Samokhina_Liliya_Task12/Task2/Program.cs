using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            FileChangesSaver saver = new FileChangesSaver("D:\\test\\", "D:\\save\\");

            Console.WriteLine("Choose mode:");
            Console.WriteLine("1 - watch");
            Console.WriteLine("2 - rollback");
            string mode = Console.ReadLine();
            switch (mode)
            {
                case "1":
                    saver.BeginWatch();
                    logger.Write("Watcher started");
                    break;
                case "2":
                    var dirNames = Directory.GetDirectories(saver.SavingDirectory);
                    Console.WriteLine("Choose time to rollback, enter the number:");
                    for (int i = 0; i < dirNames.Length; i++)
                    {
                        Console.WriteLine($"{i} - {dirNames[i]}");
                    }
                    string number = Console.ReadLine();
                    saver.RollBack(int.Parse(number));
                    logger.Write($"Roll back to {number}");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
