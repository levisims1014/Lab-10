using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Validator
    {
        public static double ValidateRadius()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please enter the radius of a circle: ");
                    double num = double.Parse(Console.ReadLine());
                    return num;

                }
                catch (FormatException)
                {
                    Console.Write("That input is not valid! Please try again");
                }
            }
        }
    }
}
