using System;
using Shape.Models; 


namespace Shape
{
    public class Program
    {
        public static void Main()
        {
            Triangle bob = new Triangle(0,0,0);
            Console.WriteLine("Please enter a value for side 1: ");
            string side1str = Console.ReadLine();
            int side1 = int.Parse(side1str);
            Console.WriteLine("Please enter a value for side 2: ");
            string side2str = Console.ReadLine();
            int side2 = int.Parse(side2str);
            Console.WriteLine("Please enter a value for side 3: ");
            string side3str = Console.ReadLine();
            int side3 = int.Parse(side3str);
            bob.Side1 = side1;
            bob.Side2 = side2;
            bob.Side3 = side3;

            if (bob.CheckIfTriangle())
            {
                string result = bob.CheckType();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Sorry that isn't a triangle!");
            }
        }
    }
}