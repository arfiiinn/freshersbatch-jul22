using System;

namespace CSharpAssignment1
{
    class Circle
    {
        static void CircleDimensions(int r, out double area, out double circumference) 
        {
            area = 3.142 * r * r;
            circumference = 2 * 3.142 * r;
        }

        public static void Main()
        {
            int radius;
            double area, circumference;
            Console.Write("Enter radius for circle: ");
            radius = Convert.ToInt32(Console.ReadLine());
            CircleDimensions(radius,out area,out circumference);
            Console.WriteLine($"Radius : {radius}");
            Console.WriteLine($"Area : {area} sq. units");
            Console.WriteLine($"Circumference : {circumference} units");
        }
    }
}
