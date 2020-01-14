using System;

namespace console_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            functions.Welcome();
            functions.CenterOutput("");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    User.Login();
                    break;
                case "2":
                    User.Register();
                    break;
                }
            
        }
    }
}
