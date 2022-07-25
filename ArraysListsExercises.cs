using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class ArraysListsExercises
    {
        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        public static void Main1()
        {
            var likers = new List<string>();
            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                likers.Add(input);
            }

            if (likers.Count > 2)
            {
                Console.WriteLine("{0},{1} and {2} others like your post", likers[0], likers[1], likers.Count - 2);
            }
            else if (likers.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", likers[0], likers[1]);
            }
            else if (likers.Count == 1)
            {
                Console.WriteLine("{0} likes your post", likers[0]);
            }
            else
            {
                Console.WriteLine("");
            }

        }
        //2- Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        public static void Main2()
        {

            Console.Write("Please enter your full name: ");
            var name = Console.ReadLine();

            var nameArray = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                nameArray[name.Length - i] = name[i - 1];

            var reversed = new string(nameArray);
            Console.WriteLine("Reversed name: " + reversed);

        }

        //3- Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void Main3()
        {
            
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered "+ number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }          
        }
        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        public static void Main4()
        {
          
            var numbers=new List<int> ();
            
            while (true)
            {
                Console.WriteLine("Please enter the number or type 'Quit' to exit: ");
                var input=Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                numbers.Add (Convert.ToInt32 (input));
            }
            
            //var uniques=new List<int>();
            //foreach (var item in numbers)
            //{
            //    if(!uniques.Contains(Convert.ToInt32 (item)))
            //        uniques.Add(Convert.ToInt32 (item));
            //}

            //Console.WriteLine("Unique numbers: ");
            //foreach (var item in uniques)
            //{
            //    Console.WriteLine(item);
            //}

            var uniques = numbers.Distinct().ToList();
            Console.WriteLine("List after removing duplicated numbers: ");
            uniques.ForEach(Console.WriteLine);

        }

        //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.
        public static void Main5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Please enter a list of comma separated numbers : ");
                var input=Console.ReadLine();

                if(!string.IsNullOrEmpty(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("This is Invalid List. Please re-entry the digits");               
            }
            var lst = new List<int>();
            foreach (var number in elements)
               lst.Add(Convert.ToInt32(number));

            var smallests=new List<int>();
            while (smallests.Count<3)
            {
                //assume first umber is the smallest one
                var min = lst[0];
                foreach (var number in lst)
                {
                    if (number<min)
                    {
                        min = number;
                    }
                }
                smallests.Add(min);
                lst.Remove(min);
            }

            Console.WriteLine("Smallests numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);

        }
    }
}
