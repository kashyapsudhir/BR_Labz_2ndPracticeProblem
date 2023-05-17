using System;
namespace LineComparisionProblems
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line calculator");



            Console.WriteLine("Enter the points of First line");

            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(length);


            Console.WriteLine("Enter the points of Second line");

            Console.WriteLine("Enter x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(length2);

            if (length.CompareTo(length2) > 0)
                Console.WriteLine("Line1 is greater than line1");
            else if (length.CompareTo(length2) < 0)
                Console.WriteLine("Line2 is greater than line1");
            else
                Console.WriteLine("Both lines are equal");


        }
    }
}