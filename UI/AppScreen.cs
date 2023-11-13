using ATM_Application.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Application.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            // clears the window
            Console.Clear();

            // sets the title of the window
            Console.Title = "My ATM App";

            // sets foreground color
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\n\n-----------Welcome to MyTM card------------\n");

            //prompt user to insert atm card
            Console.WriteLine("Please Insert your ATM card");
            Console.WriteLine("Note: Actual ATM will accept and validate a physical ATM Card, read the card number and validate it.");

            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your PIN"));

            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrindDOtAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();

            Utility.PrintMessage("Your account is locked!\nPlease go to the nearest bank to unlock.\nThank you.", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
    }
}
