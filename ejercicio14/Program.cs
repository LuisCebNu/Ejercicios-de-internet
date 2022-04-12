using System;

namespace ejercicio14
{
    class Program 
    {
        /*
         * Exercise 14
         * Write a program that can find the distance bewteen two
         * points, given the points x and y coordinates
         
             */
        static void Main(string[] args)
        {
            Point mypoint = new Point();
            

            Console.WriteLine("Enter the X coordinates for point 1: ");
            mypoint.x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y coordinates for point 1: ");
            mypoint.y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the X coordinates for point 2: ");
            mypoint.x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y coordinates for point 2: ");
            mypoint.y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mypoint.distance());

            Console.WriteLine();


        }
    }
}
