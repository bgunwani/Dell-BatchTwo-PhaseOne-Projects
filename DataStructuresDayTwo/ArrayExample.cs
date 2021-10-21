/*using System;

namespace DataStructuresDayTwo
{
    class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        public void insert(int item)
        {
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (Twice of the Size)
                int[] newItems = new int[count * 2];
                // Copy all the existing items
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];
                // Set 'items' to this new array.
                items = newItems;
            }
            // Add the new item at the end
            items[count++] = item;
        }
        public void removeAt(int index)
        {
            // Validate the Index
            if (index < 0 || index >= count)
                throw new ArgumentException();
            // Shift the items to the left to fill the hole
            for (int i = index; i < count; i++)
                items[i] = items[i + 1];
            count--;
        }
        public int indexOf(int item)
        {
            // If we find index, return index
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }
            // Othewise return -1
            return -1;
        }

    }
    class ArrayExample
    {
        static void Main(string[] args)
        {
            Array array = new Array(5);
            array.insert(100);
            array.insert(200);
            array.insert(300);
            array.insert(400);
            array.insert(500);
            array.insert(600);
            array.print();
            Console.WriteLine("***********");
            array.removeAt(2);
            array.print();
            Console.WriteLine("***********");
            Console.WriteLine(array.indexOf(500)!=-1 ? "Item Exists" : "Item Not Exist");
            Console.ReadKey();
        }
    }
}
*/