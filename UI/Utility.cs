using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Application.UI
{
    public static class Utility
    {
        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string asterisks = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);

                isPrompt = false;

                ConsoleKeyInfo inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if (input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMessage("\nPlease enter 6 digits", false);
                        input.Clear();
                        isPrompt = true;
                        continue;
                    }
                }

                if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                }
                else if (inputKey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputKey.KeyChar);
                    Console.Write(asterisks + "*");
                }
            }

            return input.ToString();

        }
        public static void PrintMessage(string message, bool success = true)
        {
            Console.ForegroundColor = success ? ConsoleColor.Yellow : ConsoleColor.Red;

            Console.WriteLine(message);
            Console.ResetColor();
            PressEnterToContinue();

        }
        public static string? GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void PrindDOtAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(200);
            }
            Console.Clear();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
