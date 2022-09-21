using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node //Represents Node Object. Has the 2 things found in the node(next pointer & data)
    {
        public Node next; //pointer to another node
        public Object data;

        public Node(int val = 0, Node next = null)
        {
            this.data = val;
            this.next = next;
        }
    }
    public class LinkedList3
    {
       
        

        private Node head; //tells us where the head is
        private Node tail;
        public int currentSize = 0;
        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(" " +current.data);

                current = current.next;

            }
        }
        public void addLast(Object data)
        {

            Node newNode = new Node();

            if (tail == null && head == null) //First boundary condition, empty list
            {
                head = newNode;
                tail = newNode;
                currentSize++;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                currentSize++;
            }
            newNode.data = data;
        }

        //remove
        public void remove2(Object data)
        {
            if (head == null)
                Console.WriteLine("Head is null");
            Node current = head;
            Node previous = null;
            while (current != null)
            {

                if (current.data.Equals(data))
                {
                    Object tmp = current.data;

                    previous.next = current.next;

                }
                previous = current;
                current = current.next;
            }
            Console.WriteLine("Loop complete item not found");
        }

        BinaryMaxHeap


    }
}
