using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("User, what is your name?");
            userName = Console.ReadLine();
            bool run = true;

            while (run)
            {
                int userNumber, userResult;
                Console.WriteLine(userName + " Please enter an integer 1-100.");
                userNumber = Convert.ToInt32(Console.ReadLine());
                userResult = userNumber % 2;
                if (userNumber > 1 && userNumber < 100)
                {

                    if (userResult == 0) //0 means it is an even number
                    {
                        if (userNumber <= 25 && userNumber >= 2)
                        {
                            Console.WriteLine(userName + ", your number " + userNumber + " is even and less than 25.");
                        }
                        else if (userNumber <= 60 && userNumber >= 26)
                        {
                            Console.WriteLine(userName + ", your number is even");
                        }
                        else
                        {
                            Console.WriteLine(userName + ", your number " + userNumber + " is even");
                        }

                    }
                    else
                    {
                        Console.WriteLine(userName + " your number " + userNumber + " is odd.");
                    }
                }
                else
                {
                    Console.WriteLine("That is an invalid entry.");
                }
                string userResponse;
                Console.WriteLine("Would you like to run it again? (y/n):");
                userResponse = Console.ReadLine();
                userResponse = userResponse.ToLower();
                if (userResponse == "n")
                {
                    run = false;
                }


            }
        }
    }
}
