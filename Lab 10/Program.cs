using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_10
{
    class Program
    {
        static int repeats = 0;
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                double UserInput = 0;
                Circle myCircle = new Circle(Validator.ValidateRadius());
                Console.WriteLine("Please enter the radius of a circle!");
                UserInput = double.Parse(Console.ReadLine());
                myCircle.Radius = UserInput;
                Console.WriteLine($"Circumference Formatted! {myCircle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {myCircle.CalculateFormattedArea(),0:N2}");

                repeat = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string answer = Console.ReadLine().ToLower();
            bool again = true;

            if (answer == "y")
            {
                again = true;
            }
            else if (answer == "n")
            {
                again = false;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please try again");
                again = Continue();
            }
            return again;
        }
    }
}