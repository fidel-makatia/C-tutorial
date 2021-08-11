using System;

namespace Harshabank
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*******MY BANK***********");
            Console.WriteLine("-------LOG IN--------");
            
            //declare variables
            string userName = null;
            string passWord = null;
            string Choice;

            //allow user to enter values
            Console.WriteLine("Enter Username");
            Start:
            userName = Console.ReadLine();
            if (userName != "")
            {
                Console.WriteLine("Enter Password");
                passWord = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please Enter a valid Username");
                goto Start;
            }
            if (userName == "Fidel" && passWord == "Makatia")
            {
                int menuChoice = -1;
                do
                {
                    Console.WriteLine("\n::Main Menu::");
                    Console.WriteLine("1. Accounts");
                    Console.WriteLine("2. Customers");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Account Statements");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Enter Choice");
                    menuChoice = int.Parse(Console.ReadLine());
                    //switch of choice
                    switch (menuChoice)
                    {
                        case 1:
                            customerMenu();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;

                        case 4:
                            break;
                        default:
                            break;

                    }
                } while (menuChoice != 0);
            }
            else
            {
                Console.WriteLine("invalid values");
            }

            Console.WriteLine("Thank you for banking with us");
        }

        static void customerMenu()
        {
            Console.WriteLine("The Customers");
        }
    }
}