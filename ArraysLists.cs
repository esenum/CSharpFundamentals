using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class ArraysLists
    {
        public static void Main()
        {
            var numbers =new[] {94,4,5,2,90,9};

            //Length
            Console.WriteLine("The length of an array is: "+numbers.Length);

            //IndexOf()
            var index=Array.IndexOf(numbers,9);
            Console.WriteLine("Index of 9: "+ index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear(): ");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers,another,3);

            Console.WriteLine("Effect of Copy(): ");
            foreach (var item in another)        
                Console.WriteLine(item);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort(): ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Reverse()

            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main2()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[4] { 1, 2, 3, 5 });

            foreach (var item in numbers)            
                Console.WriteLine(item);           

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);


            for (var i=0;i<numbers.Count;i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i--]);
                }
            }
            foreach (var item in numbers)
                Console.WriteLine(item); 
            
            numbers.Clear();
            Console.WriteLine("Count:"+numbers.Count);
        }
    }
}
