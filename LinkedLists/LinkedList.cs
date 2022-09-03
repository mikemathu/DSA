namespace LinkedLists
{
    public class LinkedList
    {
        public class Node //Represents Node Object. Has the 2 things found in the node(next pointer & data)
        {
            public Node next; //pointer to another node
            public Object data; 
        }

        private Node head; //tells us where the head is
        private Node tail;
        public int currentSize = 0;
        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                
                current = current.next;
                
            }
        }
      /*  public void addFirst(Object data)
        {
            Node newNode = new Node(); //1. Create new node
            if (tail == null && head == null) //First Boundry condition i.e empty list
            {
                head = newNode;
                tail = newNode; //update a tail pointer if we have an empty list
                currentSize++;

            }
            else
            {
                newNode.next = head;  //2.make newNode point to the first/previous node i.e where the head is currently pointing
                head = newNode; //3. now make the head point to the newNode
                currentSize++;

            }
            newNode.data = data;
        }*/

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

        public void removeFirst()
        {
            if(head == null) //Empty list
            {
                Console.WriteLine("nulll");
            }

            Object tmp = head.data;

            if(head == tail) //signle element
            {
                head = null;
                tail = null;
                Console.WriteLine("sinlge element");
            }
            else
            {
                head = head.next;
                currentSize--;
                Console.WriteLine ( tmp);
            }

        }

        public void removeLast()
        {
            if (head == null) //Empty list
            {
                Console.WriteLine("null item");
            }

            if (head == tail) //signle element
            {
                 removeFirst();
            }

            Node current = head;
            Node previous = null;

            while(current != tail) //brings O(n) complexity
            {
                previous = current;
                current = current.next;
            }
            previous.next = null;
            tail = previous;
            currentSize--;
            Console.WriteLine(current.data);
        }

        public void remove(Object data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if((( IComparable)data).
                    CompareTo(current.data) == 0)
                {
                    if (current == head)
                        removeFirst();
                    /*if (current == tail) //not important
                        removeLast();*/
                    currentSize--;
                    previous.next = current.next;
                    Console.WriteLine(current.data);
                }
                previous = current;
                current = current.next;
            }
            Console.WriteLine("not found ");
        }

        public void contain(Object data) //aslo called has()/find() method
        {
            Node current = head;

            while (current != null)
            {
                if (((IComparable)data).
                    CompareTo(current.data) == 0)
                {
                    Console.WriteLine(true + " found");
                }
                current = current.next;
            }
            Console.WriteLine(false + "its not there");


        }
    }
 }
