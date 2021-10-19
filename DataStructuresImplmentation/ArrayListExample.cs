/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplmentation
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Initial Capacity : " + list.Capacity);
            list.Add(100);
            Console.WriteLine("Capacity after adding 1 element : " + list.Capacity);
            list.Add("King");
            list.Add(true);
            list.Add(3.14F);
            Console.WriteLine("Capacity after adding fourth element : " + list.Capacity);
            list.Add(500);
            Console.WriteLine("Capacity after adding fifth element : " + list.Capacity);


            Console.WriteLine("**********************************");

            // Printing the ArrayList elements using for loop
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + "   ");

            Console.WriteLine();
            Console.WriteLine("**********************************");

            // Printing the ArrayList elements using foreach loop
            foreach (object obj in list)
                Console.Write(obj + "   ");

            // Remove elements from ArrayList
            list.Remove("King");
            list.RemoveAt(1);
            list.RemoveRange(1, 2);

            Console.WriteLine();
            Console.WriteLine("**********************************");

            // Printing the ArrayList elements using foreach loop
            foreach (object obj in list)
                Console.Write(obj + "   ");

            Console.ReadKey();
        }
    }
}
*/