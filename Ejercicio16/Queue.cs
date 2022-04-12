using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Queuec<T>
    {
        List<T> data;

        public Queuec()
        {

            data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            Console.WriteLine($"{item.ToString()} has been added to the queue.");


        }

        public T Dequeue()
        {
            T item = data[0];
            data.RemoveAt(0);
            return item;


        }

            

    }
}
