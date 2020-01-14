using System;
using System.Collections.Generic;
using System.Text;

namespace console_bank
{
    class User
    {
        public List<Account> accountNumber = new List<Account>();
        public string firstName,lastName;
        public string dateOfBirth;
        public string address;
        public string password;
        public string email;

        public static void Login() {
            Console.Clear();
            functions.Welcome();
            Console.WriteLine("\n\n");

            functions.Message("Enter Email: " , ConsoleColor.DarkYellow);
            functions.CenterOutput("          ");
            string email = Console.ReadLine();

            functions.Message("Enter Password: " , ConsoleColor.DarkYellow);
            functions.CenterOutput("    ");
            string password = Console.ReadLine();

            if (email == "admin" && password == "0000")
            {
                Console.Clear();
                functions.Welcome();
                functions.AdminMenu();
            }
        }

        public static void Register()
        {
            Account userAccount = new Account();
            var formatString = "+------------------------------------------+";

            Console.Clear();
            functions.Welcome();
            functions.Message(formatString , ConsoleColor.DarkMagenta);

            functions.CenterOutput(formatString);
            Console.Write("Firstname: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            functions.CenterOutput(formatString);
            Console.Write("Lastname: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            functions.CenterOutput(formatString);
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine();

            functions.CenterOutput(formatString);
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            functions.CenterOutput(formatString);
            Console.Write("Address: ");
            string address = Console.ReadLine();

            functions.Message(formatString , ConsoleColor.DarkMagenta);
            }

    }

    
    
}
