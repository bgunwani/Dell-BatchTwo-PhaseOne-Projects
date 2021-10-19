using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplmentation
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("King");
            queue.Enqueue("Kochhar");
            queue.Enqueue("Smith");
            queue.Enqueue("Sarah");

            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            Console.WriteLine("Element Dequeued : " + queue.Dequeue());

            Console.WriteLine("***********************************");

            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            Console.WriteLine("Element ready to Dequeue : " + queue.Peek());
            Console.WriteLine("Element Dequeued : " + queue.Dequeue());

            Console.WriteLine("***********************************");

            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("***********************************");

            if (queue.Count != 0)
                Console.WriteLine("Queue is not empty.");
            else
                Console.WriteLine("Queue is empty.");

            Console.ReadKey();
        }
    }
}
