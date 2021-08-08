using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCondition = true;
            
            Console.WriteLine("Please enter your name: "); // prompt user for name
            
            string userName = Console.ReadLine(); // input user name
            
            while (exitCondition)
            {
                Console.WriteLine($"{userName} enter a number between 1-100 "); // prompt user to input a valid number

                 
                bool checkNumber = int.TryParse(Console.ReadLine(), out int inputNumber);  // input user string and convert to int

                if (!checkNumber || inputNumber < 1 || inputNumber > 100 )  // verify input is valid
                {
                    Console.WriteLine($"I'm sorry, {userName}, that input is not valid."); // display if user number is out of range or not and int
                   
                    Console.WriteLine($"{userName} would you like to continue? (y/n)"); // prompt user to continue or exit

                    if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                    {
                        exitCondition = false;
                        Console.WriteLine("Good Bye");
                    }
                } 

                else
                {
                    // conditional statements for each case
                    if (inputNumber % 2 != 0 && inputNumber < 60)
                    {
                        Console.WriteLine($"{userName} your number is {inputNumber} and Odd");
                    }

                    else if (inputNumber % 2 != 0 && inputNumber > 60)
                    {
                        Console.WriteLine($"{userName} your number is {inputNumber} and Odd");
                    }

                    else if (inputNumber % 2 == 0 && inputNumber < 25)
                    {
                        Console.WriteLine($"{userName} your number is even and less than 25");
                    }

                    else if (inputNumber % 2 == 0 && inputNumber <= 60)
                    {
                        Console.WriteLine($"{userName} your number is Even");
                    }

                    else if (inputNumber % 2 == 0 && inputNumber > 60)
                    {
                        Console.WriteLine($"{userName} your number is {inputNumber} and Even");
                    }
                    

                    Console.WriteLine($"{userName} would you like to continue? (y/n)"); // prompt user to continue or exit
                    
                    if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                    {
                        exitCondition = false;
                        Console.WriteLine("Good Bye");
                    }
                    
                }
            }
            
        }
    }
}
