using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Queuec<int> q = new Queuec<int>();
            int selection;

            do
            {

                Console.WriteLine("1.Enqueue");
                Console.WriteLine("2.Dequeue");
                Console.WriteLine("3. Exist");
                selection = Convert.ToInt32(Console.ReadLine());

                if(selection == 1)
                {
                    Console.WriteLine("Enter Item in queue: ");
                    q.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine();

                }

                else if(selection == 2)
                {
                    Console.WriteLine($"{q.Dequeue().ToString()} has been remove from the queue");
                    Console.WriteLine();
                }


            }

            while (selection != 3);

        }
    }
}
