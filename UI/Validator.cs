using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Application.UI
{
    public static class Validator
    {
        public static T? Convert<T>(string prompt)
        {
            bool valid = false;

            while (!valid)
            {
                var userInput = Utility.GetUserInput(prompt);

                try
                {
                   var converter =  TypeDescriptor.GetConverter(typeof(T));
                   if (converter != null)
                   {
                       return (T)converter.ConvertFromString(userInput);
                   }
                   else
                   {
                       return default;
                   }
                }
                catch
                {
                    Utility.PrintMessage("Invalid input. Try again", false);
                }
            }

            return default;
        }
    }
}
