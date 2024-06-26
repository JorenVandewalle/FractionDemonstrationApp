﻿using FractionLibrary;

namespace FractionDemonstrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();
            Fraction leftfraction = new Fraction(1,2);
            Fraction rightfraction = new Fraction(3,4);

            Fraction add = leftfraction.Add(rightfraction);
            Fraction subtract = leftfraction.Subtract(rightfraction);
            Fraction multiply = leftfraction.Multiply(rightfraction);
            Fraction divide = leftfraction.Divide(rightfraction);

            Fraction result = new Fraction();

            Console.WriteLine($"Left fraction: {leftfraction.ToString()}     Right fraction: {rightfraction.ToString()}");

            Console.WriteLine($"Add: {add.Simplify().ToString()}"); 
            Console.WriteLine($"Subtract: {subtract.Simplify().ToString()}");
            Console.WriteLine($"Multiply: {multiply.Simplify().ToString()}");
            Console.WriteLine($"Divide: {divide.Simplify().ToString()}");

            Console.WriteLine($"Reciprocal of Add: {add.Reciprocal().Simplify().ToString()}");
            Console.WriteLine($"Invert of Add: {add.Invert().Simplify().ToString()}");
            Console.WriteLine($"Result in double of Add: {add.Result()}");
        }
    }
}
