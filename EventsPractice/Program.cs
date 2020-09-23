using System;

namespace EventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            PiggyBank piggyBank = new PiggyBank();

            piggyBank.takeEvent += MoneyChanged;
            piggyBank.takeEvent += Reached;

            do
            {
                Console.WriteLine("How much to deposit?");
                command = Console.ReadLine();
                if (command.Equals("exit"))
                {
                    return;
                }

                int value = int.Parse(command);
                piggyBank.Money += value;

            } while (!command.Equals("exit"));
        }

        static void MoneyChanged(int value)
        {
            Console.WriteLine($"The money amount is {value}");
        }

        static void Reached(int value)
        {
            if (value >= 500)
            {
                Console.WriteLine($"You reached your savings goal! You have {value}");
            }
        }
    }
}
