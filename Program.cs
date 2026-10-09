using LoyaltyPointsBusinessLogic;

namespace PUPLoyaltyPointsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PUP Loyalty Points System");

            DisplayOptions();

            string facultyNumber = "2015ABC000";

            List<string> facultyNumbers = new List<string>();
            facultyNumbers.Add("2015ABC123");
            facultyNumbers.Add("2015ABC111");
            facultyNumbers.Add("2016ABC111");
            facultyNumbers.Add("2013ABC111");

            string checkLogin = Console.ReadLine();

            string studentNumber = "2011-00066-BN-0";

            int studentPoints = 100;

            while (checkLogin != "x")
            {
                if (checkLogin == "1")
                {
                    studentPoints = ProcessFacultyModule(facultyNumber, studentNumber, studentPoints);
                }
                else if (checkLogin == "2")
                {
                    Console.Write("Enter your student number:");

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
                                Console.WriteLine($"Your total available points is {studentPoints}");
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
                DisplayOptions();
                checkLogin = Console.ReadLine();
            }            
        }

        static void DisplayOptions()
        {
            Console.WriteLine("Enter 1 - for Faculty Login");
            Console.WriteLine("Enter 2 - for Student Login");
            Console.WriteLine("Enter x - to exit");
            Console.Write("User Input: ");
        }

        static int ProcessFacultyModule(string facultyNumber, string studentNumber, int studentPoints)
        {
            Console.Write("Enter faculty number: ");
            string facultyInput = Console.ReadLine();

            AuthenticationLogic businesslogic = new AuthenticationLogic();

            if (businesslogic.IsFacultyNumberCorrect(facultyInput))
            {
                Console.Write("Enter the student number you want to give points to:");

                string checkStudentNumber = Console.ReadLine();

                if (checkStudentNumber == studentNumber)
                {
                    Console.Write("Enter points you want to give: ");
                    int pointsToGive = Convert.ToInt16(Console.ReadLine());
                    studentPoints += pointsToGive;
                }
            }

            return studentPoints;
        }
    }
}