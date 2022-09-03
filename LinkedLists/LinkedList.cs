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
   /*     public void AddFirst(Object data)
        {
            Node newNode = new Node(); //1. Create new node
            if (tail == null && head == null) //empty list
            {
                head = newNode;
                tail = newNode;
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

       /* public void AddLast(Object data)
        {


            Node newNode = new Node();

            if (tail == null && head == null) //empty list
            {
                head = newNode;
                tail = newNode;

            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            newNode.data = data;
        }*/

    }
 }
