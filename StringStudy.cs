using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class StringStudy
    {
        public static void Main1()
        {
            {
                var fullName = "Umut Esen";
                Console.WriteLine("Trim:'{0}'", fullName.Trim());
                Console.WriteLine("ToUpper:'{0}'", fullName.Trim().ToUpper());

                var index = fullName.IndexOf(' ');
                var firstName = fullName.Substring(0, index);
                var lastName = fullName.Substring(index + 1);
                Console.WriteLine("FirstName: " + firstName);
                Console.WriteLine("LastName: " + lastName);

                var names = fullName.Split(' ');
                Console.WriteLine("FirstName: " + names[0]);
                Console.WriteLine("LastName: " + names[1]);

                Console.WriteLine(fullName.Replace("Umut", "Tumu"));

                if (string.IsNullOrWhiteSpace(" "))
                    Console.WriteLine("Invalid");

                var str = 25;
                var age = Convert.ToByte(str);
                Console.WriteLine(age);

                float price = 29.95f;
                Console.WriteLine(price.ToString("C0"));

            }
        }

        static void Main(string[] args)
        {

            //Summarising Text
            {
                var sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
                var summary = StringUtility.SummarizeText(sentence, 40);
                Console.WriteLine(summary);
            }

        }

    }
}

