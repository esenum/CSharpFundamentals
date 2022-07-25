using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class ProceduralProgramming
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " +reversed);
        }
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i-1];

            return new string(array);
        }

        public static void Main2(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter the number or type 'Quit' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            //var uniques = GetUniqueNumbers(numbers);
            Console.WriteLine("Unique numbers: ");
            foreach(var item in GetUniqueNumbers(numbers))
                Console.WriteLine(item);
        }
        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            //Core Logic

            var uniques = new List<int>();
            foreach (var item in uniques)
            {
                if (!uniques.Contains(item))
                    uniques.Add(item);
            }
            return uniques;
        }


    }
}
