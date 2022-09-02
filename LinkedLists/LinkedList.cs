namespace LinkedList
{
    public class LinkedList
    {
        public class Node
        {
            public Node next;
            public Object data;
        }
        Node head;
        Node tail;
        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            if (tail == null && head == null) //empty list
            {
                head = toAdd;
                tail = toAdd;
            }
            else
            {
                toAdd.next = head;
                head = toAdd;
            }
            toAdd.data = data;
        }
    }
 }
