using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Stopwatch;

namespace Stopwatch
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'Start' to start stopwatch," +
                " 'Stop' to end, or 'Exit' to quit: ");
            var input = Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            bool isStarted = false;
            bool isAlredyStarted = false;

            while (input.ToLower() != "exit")
            {
                if (input.ToLower() == "start")
                {
                    if (isAlredyStarted)
                    {
                        throw new InvalidOperationException(
                            "Stopwatch is already started");
                    }
                    else
                    {
                        stopwatch.Start();
                        isStarted = true;
                        isAlredyStarted = true;
                        Console.WriteLine("Timer starts, write 'Stop' to stop the timer: ");
                        input = Console.ReadLine();
                    }
                }
                else if (input.ToLower() == "stop")
                {
                    if (isStarted)
                    {
                        isStarted = false;
                        isAlredyStarted = false;
                        stopwatch.Stop();
                        Console.WriteLine("Timer stops, write 'Start' or 'Exit':");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You need to type 'Start' to start the timer: ");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Type 'Start', 'Stop' or 'Exit': ");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Ty for using this app");
        }
    }
}