using System;

namespace OpExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 // write out the results of addition, subtraction, multiplication, division, and modulus operations.

            int a = 17;
            int b = 4;
            int quotient = a/b;
            int remainder = a%b;
            Console.WriteLine("if a = 17 and b = 4");
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("b - a = " + (b - a));
            Console.WriteLine("a * a = " + (a * a));
            Console.WriteLine("a / b = " + quotient);
            Console.WriteLine("a % b = " + remainder);
            Console.WriteLine($"so {a} / {b} is {quotient} with the a remainder of {remainder}");
            Console.WriteLine();

                // method that will Calculate the area of a circle based on its radius

            Console.WriteLine("Now we are going to calculate the area of a circle");
            Console.WriteLine("What is the radius of the circle?");
            var r = double.Parse(Console.ReadLine());
            double AreaOfCircle = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("The area of a circle with the radius of 20 is " + AreaOfCircle);
            Console.WriteLine("This Program is now complete, good bye.");
                

        }
    }
}
