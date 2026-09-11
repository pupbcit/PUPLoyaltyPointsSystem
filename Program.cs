using System;

namespace PUPLoyaltyPointsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PUP Loyalty Points System");

            Console.Write("Enter your student number:");

            string studentNumber = "2011-00066-BN-0";

            string userInput = Console.ReadLine();
            bool response = userInput == studentNumber;

            if (response)
            {
                Console.WriteLine("Welcome!!");

                Console.WriteLine("Type 1 - to view your points");
                Console.WriteLine("Type 2 - to redeem");
                Console.WriteLine("Type 3 - to exit");

                Console.Write("Enter your option:");
                int choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your total available points is 100");
                        break;
                    case 2:
                        Console.WriteLine("Redeem feature is still in progress...");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for your using Loyalty Points System");
                        break;
                    default:
                        Console.WriteLine("Incorrect input...");
                        break;
                }
            }

        }
    }
}
