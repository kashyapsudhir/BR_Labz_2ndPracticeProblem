using LineComparision;
using System;
namespace LineComparisionProblems
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line calculator");

            Console.Write("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            CalculateLength line = new CalculateLength(x1, y1, x2, y2);
            double length = line.GetLength();

            Console.WriteLine("Length of the line: " + length);

        }
    }
}