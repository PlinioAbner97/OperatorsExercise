using System;

namespace OperatorsExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
               
            Console.WriteLine($"{a}/{b} is a remainder 1");

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);
        }
    }
}
