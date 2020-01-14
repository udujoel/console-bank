using System;
using System.Collections.Generic;
using System.Text;

namespace console_bank
{
    class functions
    {
        public static void Welcome()
        {
            var dots = "****************************************************";
            var welcomMsg = "Welcome to DECAGON CONSOLE bank";
            Message(dots,ConsoleColor.Green);
            Console.WriteLine();

            Message(welcomMsg,ConsoleColor.Green);
            Console.WriteLine();

            Message(dots,ConsoleColor.Green);


            Console.WriteLine("                                  +---------------------------------------------------+");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  |               1.  Login.                          |");
            Console.WriteLine("                                  |               2.  Register.                       |");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  +---------------------------------------------------+");
            }

        public static void Message(string msg, ConsoleColor color)
        {
            CenterOutput(msg);
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void CenterOutput(string textToDisplay)
        {
            Console.SetCursorPosition((Console.WindowWidth - textToDisplay.Length) / 2, Console.CursorTop);
        }

        public static void Menu()
        {
            Console.WriteLine();
            //Console.SetCursorPosition(5,Console.CursorTop);
            Console.WriteLine("                                  +---------------------------------------------------+");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  |               1.  Create Another Account          |");
            Console.WriteLine("                                  |               2.  Check Account Balance           |");
            Console.WriteLine("                                  |               3.  Deposite Funds                  |");
            Console.WriteLine("                                  |               4.  Withdraw Funds                  |");
            Console.WriteLine("                                  |               5.  Transfer Funds                  |");
            Console.WriteLine("                                  |               6.  View Account Statement          |");
            Console.WriteLine("                                  |               7.  Logout                          |");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  +---------------------------------------------------+");
            Console.WriteLine();
            Message("+----------------------------+",ConsoleColor.DarkMagenta);
            Message("|Choose an Operation:  (1-7):|",ConsoleColor.DarkMagenta);
            Message("+----------------------------+" , ConsoleColor.DarkMagenta);
        }

        public static void AdminMenu()
        {
            Console.WriteLine();
            //Console.SetCursorPosition(5,Console.CursorTop);
            Console.WriteLine("                                  +---------------------------------------------------+");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  |               1.  Create an Account               |");
            Console.WriteLine("                                  |               2.  Update an Account               |");
            Console.WriteLine("                                  |               3.  View All Accounts               |");
            Console.WriteLine("                                  |               4.  LogOut                          |");
            Console.WriteLine("                                  |                                                   |");
            Console.WriteLine("                                  +---------------------------------------------------+");
            Console.WriteLine();
            Message("+----------------------------+" , ConsoleColor.DarkMagenta);
            Message("|Choose an Operation:  (1-4):|" , ConsoleColor.DarkMagenta);
            Message("+----------------------------+" , ConsoleColor.DarkMagenta);

            }
    }
}
