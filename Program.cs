using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Chose one of this modes below: ");
            Console.WriteLine("S = Second => 10s = 10 seconds");
            Console.WriteLine("M = Minute => 1m = 1 minute");
            Console.WriteLine("0 = Leave");
            Console.WriteLine("How much time do you want to count?");

            string date = Console.ReadLine().ToLower();
            if(date=="0")
                System.Environment.Exit(0);
            char type = char.Parse(date.Substring((date.Length - 1), 1));
            int time = int.Parse(date.Substring(0, date.Length - 1));


            switch (type)
            {
                default:
                    Console.WriteLine("Type not found.");
                    Thread.Sleep(2500);
                    Menu();
                    break;

                case 's':
                    PreStart(time);
                    break;

                case 'm':
                    PreStart(time * 60);
                    break;
            }
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch execution finished.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
