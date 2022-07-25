using System;




namespace Fundamentals
{

    public class Conditionals
    {

        // Write a program and ask the user to enter a number.
        // The number should be between 1 to 10.
        // If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        
        public static void Main1()
        {
            Console.WriteLine("Please enter a number between 1 and 10 : ");
            var number = Convert.ToInt32(Console.ReadLine());


            if (number > 1 && number < 10)
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");

        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>

        public static void Main2()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
                Console.WriteLine(number2);

        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        /// </summary>

        public static void Main3()
        {
            Console.WriteLine("Please enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("the image is landscape");
            }
            else
            {
                Console.WriteLine("the image is portrait");
            }
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>

        public static void Main()
        {
            Console.WriteLine("Please enter the speed limit");
            var speedLimit = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please enter the speed of a car");
            var speedOfCar = Convert.ToByte(Console.ReadLine());

            if (speedLimit > speedOfCar)
            {
                Console.WriteLine("Ok!");
            }

            else
            {

                Console.WriteLine("The punishment is calculating : ...");
                var demeritPoints = (speedOfCar - speedLimit) / 5;

                if (demeritPoints <= 12)
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
                else
                    Console.WriteLine("License is suspended");
            }
        }
    }
}

