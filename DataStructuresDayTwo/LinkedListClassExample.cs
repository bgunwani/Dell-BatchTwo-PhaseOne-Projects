using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDayTwo
{
    

    class LinkedList
    {
        class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node first;
        private Node last;
        public void addLast(int item)
        {
            var node = new Node(item);
            if(isEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }     
        }
        public void addFirst(int item)
        {
            var node = new Node(item);
            if(isEmpty())
                first = last = null;
            else
            {
                node.next = first;
                first = node;
            }
        }
        public bool isEmpty()
        {
            return first == null;
        }
        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;

        }
    }
    class LinkedListClassExample
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.addLast(100);
            linkedList.addLast(200);
            linkedList.addFirst(300);
            Console.WriteLine(linkedList.isEmpty() ? "Empty" : "Not Empty");
            Console.WriteLine("Index of Element : " + linkedList.indexOf(300));
            Console.ReadKey();
        }
    }
}
