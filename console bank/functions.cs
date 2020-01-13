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
            Console.WriteLine();
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
            Message("Choose an Operation:  (0-5):",ConsoleColor.White);
            Console.SetCursorPosition(5,Console.CursorTop);
            Console.WriteLine("\t");
        }
    }
}
