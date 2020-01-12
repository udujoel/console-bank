using System;

namespace console_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            functions.Welcome();
            functions.Message("Do you have an Account With Us? -(Y/N)",ConsoleColor.DarkYellow);
            functions.CenterOutput("");
            string response = Console.ReadLine();
            if (response.ToUpper()=="N")
            {
                functions.Message("Do You Wish to Open an Account now! -(Y/N)",ConsoleColor.DarkYellow);
                functions.CenterOutput("");
                response = Console.ReadLine();
                if (response.ToUpper()=="Y")
                {
                    User currentUser = new User();
                    int numberOfAccounts = currentUser.accountNumber.Count;
                    if (numberOfAccounts == 0)
                    {
                        currentUser.accountNumber.Add(10000000000);
                    }
                    else
                    {
                        currentUser.accountNumber.Add(currentUser.accountNumber[numberOfAccounts]+1);
                    }
                    functions.Message("Enter your First Name: ",ConsoleColor.White);
                    functions.CenterOutput("");
                    currentUser.firstName = Console.ReadLine();

                    functions.Message("Enter your Last Name: ", ConsoleColor.White);
                    functions.CenterOutput("");
                    currentUser.lastName = Console.ReadLine();

                    functions.Message("Enter your Date of Birth -(dd/mm/yyyy): ", ConsoleColor.White);
                    functions.CenterOutput("");
                    currentUser.dateOfBirth = Console.ReadLine();

                    functions.Message("Enter your Home Address: ", ConsoleColor.White);
                    functions.CenterOutput("");
                    currentUser.address = Console.ReadLine();

                    functions.Message("Here is your Details:",ConsoleColor.DarkYellow);

                    Console.WriteLine();
                    Console.WriteLine(@$"   FirstName: {currentUser.firstName}, LastName: {currentUser.lastName}
Date of Birth: {currentUser.dateOfBirth}, Address: {currentUser.address}");
                    Console.WriteLine();
                    functions.Message("Create My Account -(Y/N)",ConsoleColor.Red);
                }
            }
        }
    }
}
