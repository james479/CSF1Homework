using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            //arrays to store hard coded user names and passwords
            string[] userNames = { "james", "bob", "chirs", "joe", "trevor" };
            string[] passwords = { "james1234", "bob1234", "chris1234", "joe1234", "trevor" };

            string userName = "";

            int loginAttemptsUserName = 0;

            bool loginSuccess = false;  
            bool loginMax = false;

            while(!loginSuccess && !loginMax)
            {
                Console.Write("Enter your user name: ");
                userName = Console.ReadLine();

                //checking to see if user name exists
               if(userNames.Contains(userName))
                {
                    //check for user password
                    int index = Array.IndexOf(userNames, userName);  //get index of user name in array to match the index of the password array
                    int loginAttemptsPassword = 0;
                    bool passwordSuccess = false;

                    while(!passwordSuccess && !loginMax)
                    { 
                        Console.Write("Enter password: ");
                        string passwordInput = Console.ReadLine();
                        if(passwords[index] == passwordInput)
                        {
                            passwordSuccess = true;
                            loginSuccess = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password");
                            loginAttemptsPassword++;

                            if(loginAttemptsPassword == 3)
                            {
                                Console.WriteLine("You have excedded the max number of login attempts by password");
                                loginMax = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid user name");
                    loginAttemptsUserName++;

                    if(loginAttemptsUserName == 3)
                    {
                        Console.WriteLine("You have excedded the max number of login attempts by user name");
                        loginMax = true;
                    }
                }
            }//end while()

            if(loginSuccess)
            {
                Console.WriteLine($"You are logged in under the user name {userName}.");
            }

        }//end main()
    }//end class
}//end namespace
