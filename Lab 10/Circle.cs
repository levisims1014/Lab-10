using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_10
{
    class Circle
    {
        public const double PI = Math.PI;
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public string FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }
        public double CalculateCircumference()
        {
            double circumference = Math.PI * (radius * 2);
            return circumference;
        }
        //Allow for user input on number of decimal places
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        //public static double CalculateFormattedCircumference(double circumference)
        //{

        //}
        //public static double CalculateFormattedCircumference(double circumference, int decimalPlaces)
        //{
        //    double formatted = Math.Round(circumference, decimalPlaces);
        //    return formatted;
        //}
        public double CalculateArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }
    }
}