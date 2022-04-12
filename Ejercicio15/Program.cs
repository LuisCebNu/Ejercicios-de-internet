using System;

namespace Ejercicio15
{
    class Program
    {
        /*
         * Exercise 15
         * Write a program where the user enters the name of
         * creative works and their writers, and then program
         * outputs that information.
         
             */
        static void Main(string[] args)
        {

            Novel novel1;
            Movie movie1;
            Song song1;

            string name;
            string writer;

            Console.Write("Name of the Author: ");
            writer = Console.ReadLine();
            Console.Write("Name of the novel: ");
            name = Console.ReadLine();
            novel1 = new Novel(writer, name);

            Console.Write("Name of the screenwriter: ");
            writer = Console.ReadLine();
            Console.Write("Name of the movie: ");
            name = Console.ReadLine();
            movie1 = new Movie(name, writer);

            Console.Write("Name of the artist: ");
            writer = Console.ReadLine();
            Console.Write("Name of the song: ");
            name = Console.ReadLine();
            song1 = new Song(name, writer);


            PrintWriter(novel1);
            PrintWriter(movie1);
            PrintWriter(song1);


            Console.ReadKey();
           

           
        }


        public static void PrintWriter(IWritable display)
        {


            Console.WriteLine($"Name of artist: {display.GetWriter()}");
            Console.WriteLine($"Name of work: {display.GetNameOfWorks()}");


        }


    }


}
