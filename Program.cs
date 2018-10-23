using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {   
            Circle mycircle = new Circle(20);

            Console.WriteLine("Please enter the radius of a circle!");
           double UserInput = double.Parse(Console.ReadLine());


            Circle myCircle = new Circle(UserInput);

            Console.WriteLine($" Circumference: {myCircle.CalculateCircumference()}");
            Console.WriteLine($"Circumference Formatted! { myCircle.CalculateFormattedCircumference()}" );

            Console.WriteLine($"Area: {mycircle.CalculateArea()}");
            Console.WriteLine($"Area: {mycircle.CalculateFormattedArea()}");
           



        }
    }
}
