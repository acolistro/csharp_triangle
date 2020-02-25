using System;
using System.Collections.Generic;


namespace Shape.Models
{
    public class Triangle 
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle( int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public bool CheckIfTriangle()
        {
            if (Side1 + Side2 <= Side3 || Side2 + Side3 <= Side1 || Side1 + Side3 <= Side2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CheckType()
        {
            if (Side1 == Side2 && Side1 == Side3) 
            {
                string equilateral = "This is, without a doubt, an EQUILATERAL triangle";
                return equilateral;
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side3 == Side1)
            {
                string iso = "This here is what we call an ISOSCELES triangle";
                return iso;
            }
            else if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
            {
                string scalene = "This is the mythical SCALENE triangle";
                return scalene;
            }
            else 
            {
                string failure = "Something didnt work here";
                return failure;
            }
        }
    }
}