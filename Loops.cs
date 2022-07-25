using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Loops
    {
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
        public static void Main()

        {

            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i%3==0)
                {
                    count++;
                    
                }
            }
            Console.WriteLine("Total number divided by 3 between 1 & 100 is: "  +  count);

            
        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.



        public static void Main2()
        {

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);

        }

        //Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console. 
        public static void Main3()
        {
         
            Console.WriteLine("Please enter digit to compute factorial of it: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;


            if (number==0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (var i = 1; i <= number; i++)
                {
                    factorial *= i;                    
                }
                Console.WriteLine("{0}!= {1}", number, factorial);
            }

        }

        //  Write a program that picks a random number between 1 and 10.
        //  Give the user 4 chances to guess the number.
        //  If the user guesses the number, display “You won"; otherwise, display “You lost".
        //  (To make sure the program is behaving correctly, you can display the secret number on the console first.)

        public static void Main4()
        {

            var number = new Random().Next(1, 10);

            //Console.WriteLine("Secret is " + number);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");

        }

        // Write a program and ask the user to enter a series of numbers separated by comma.
        // Find the maximum of the numbers and display it on the console.
        // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        

        public static void Main5()
        {
            Console.WriteLine("Enter comma seperated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(",");

            //assuming first number is the max number
            var max=Convert.ToInt32(numbers[0]);    


            foreach (var str in numbers)
            {
                var number=Convert.ToInt32(str);

                if(number>max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max number is: " +max);

        }
    }
}
