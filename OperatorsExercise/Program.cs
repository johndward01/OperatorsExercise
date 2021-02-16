using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = 17;
            b = 4;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            Console.WriteLine(AreaOfCircle(a)); 
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
