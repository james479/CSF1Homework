using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            //hard coded account and pin numbers
            string[] accountNumbers = { "246812789", "67567430", "457897698", "783456321" };
            string[] pinNumbers = { "4100", "5982", "5612", "9832" };

            const int MAX_LOGIN_ATTEMPTS = 5;

            string accountNumber = "";

            //bool flags loop to check if login was a success and if max number of log in attemps were done
            bool loginMax = false;
            bool loginSuccess = false;

            //variable to keep track of number of times user logs in
            int accountNumberLoginAttempts = 0;

            //attempting to get account number and password from user
            while (!loginMax && !loginSuccess)
            {
                //getting account number from user
                Console.Write("Enter your account number: ");
                accountNumber = Console.ReadLine().Trim();

                //if account number exits will prompt user for pin number
                if (accountNumbers.Contains(accountNumber))
                {
                    int index = Array.IndexOf(accountNumbers, accountNumber);   //getting index of account number in array to match pin number
                    int pinNumberLoginAttempts = 0;

                    while (!loginMax && !loginSuccess)
                    {
                        //getting pin number from user
                        Console.Write("Enter your pin number: ");
                        string pinNumber = Console.ReadLine().Trim();

                        if (pinNumber == pinNumbers[index])
                        {
                            loginSuccess = true;
                            Console.WriteLine($"You are succesfully logged in under the account number {accountNumber}.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect pin number");
                            pinNumberLoginAttempts++;

                            //checking for max log in attemps
                            if (pinNumberLoginAttempts == MAX_LOGIN_ATTEMPTS)
                            {
                                Console.WriteLine("You have exceded the max amount of times you can attempt to enter a pin number.");
                                loginMax = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Account number not found.");
                    accountNumberLoginAttempts++;

                    //checking for max log in attemps
                    if(accountNumberLoginAttempts == MAX_LOGIN_ATTEMPTS)
                    {
                        Console.WriteLine("You have exceded the amount of times you can enter an account number to log in");
                        loginMax = true;
                    }
                }
            }//end while()

            //main part of program of successful login of account number and pin number

            bool isRunning = true;  //flag to keep the program running until user decides to quit

            double accountBalance = 0;

            do
            {
                //menu to display to user
                Console.WriteLine("Enter D to make a deposit.");
                Console.WriteLine("Enter W to make a withdrawl.");
                Console.WriteLine("Enter B to display account balance.");
                Console.WriteLine("Enter Q to quit.");

                string userChoice = Console.ReadLine().Trim().ToUpper();  //getting user input

                //switch on user choice
                switch (userChoice)
                {
                    case "D":
                    case "DEPOSIT":
                        accountBalance += makeDeposit();  //calling make deposit method
                        break;
                    case "W":
                    case "WITHDRAWL":
                        accountBalance -= makeWithdrawl(accountBalance);  //calling make withdrawl method
                        break;
                    case "B":
                    case "BALANCE":
                        Console.WriteLine($"Your account balance is {accountBalance:C2}");   //displaying account balance
                        break;
                    case "Q":
                    case "QUIT":
                        Console.WriteLine("Thank you for your business");  //quitting program by setting isRunning to false
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                //asking user if they want another transaction
                bool validChoice = false;
                do
                {
                    Console.Write("Would you like to do another transaction? (Y/N)");
                    string userPrompt = Console.ReadLine().ToUpper().Trim();
                    //user will answer yes, not or an invaid option
                    switch (userPrompt)
                    {
                        case "Y":
                        case "YES":
                            validChoice = true;   //will move into another iteration of the loop
                            break;
                        case "N":
                        case "NO":
                            validChoice = true;
                            isRunning = false;   //will terminate the program 
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (!validChoice);

            } while (isRunning);
        
        }//end main()

        //method that checks and makes sure desposit is valid
        static double makeDeposit()
        {
            double deposit;
            Console.Write("Enter the amount to deposit: ");
            bool isValid = Double.TryParse(Console.ReadLine().Trim(), out deposit);
            if (isValid)
            {
                Console.WriteLine($"You have successfully desposited an amount of {deposit:C2}");
                return deposit;
            }
            else
            {
                Console.WriteLine("Invalid currency type");
                return 0;    //return 0 if invalid currency type
            }

        }//end makeDeposit()

        //method that checks and makes sure withdrawl is valid
        static double makeWithdrawl(double accountBalance)
        {
            double withdrawl;
            Console.Write("Enter the amount to withdrawl: ");
            bool isValid = Double.TryParse(Console.ReadLine().Trim(), out withdrawl);
            if (isValid)
            {
                //check to make sure sufficent funds to withdrawl
                if (withdrawl > accountBalance)
                {
                    Console.WriteLine("Insufficient funds to withdrawl");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"You have successfully withdrawn {withdrawl:C2}.");
                    return withdrawl;
                }
            }
            else
            {
                Console.WriteLine("Invalid currency type");
                return 0;
            }
        }
    }//end class 
}//end namespace
