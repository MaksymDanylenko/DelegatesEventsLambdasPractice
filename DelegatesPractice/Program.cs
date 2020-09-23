using System;

namespace DelegatesEventsLambdasPractice
{
    delegate double SheepingFees(double price);

    class Program
    {
        static double Zone1(double price) => price * 0.25;

        static double Zone2(double price) => price * 0.12 + 25;

        static double Zone3(double price) => price * 0.08;

        static double Zone4(double price) => price * 0.04 + 25;

        static void Main(string[] args)
        {
            while (true)
            {
                SheepingFees sheepingFees = Zone1;

                Console.WriteLine("What is the destination zone?");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "exit":
                        return;
                    case "zone1":
                        sheepingFees = Zone1;
                        break;
                    case "zone2":
                        sheepingFees = Zone2;
                        break;
                    case "zone3":
                        sheepingFees = Zone3;
                        break;
                    case "zone4":
                        sheepingFees = Zone4;
                        break;
                }

                Console.WriteLine("What is the item price?");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine($"The sheeping fees are: {sheepingFees(price)}");
            }
        }
    }
}
