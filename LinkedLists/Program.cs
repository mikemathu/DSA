using LinkedList;

namespace LinkedLists
{
    class Program 
    {
        static void Main()
        {

            //EXAMPLE

            /*Node l = new Node(1);
            l.push(1);


            List list = new List();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");

            list.ListNodes();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Deleting node 8");
            list.Delete(8);
            list.ListNodes();

            Console.WriteLine();
            Console.WriteLine("Position 5: " + list.Retrieve(5).NodeContent);

            Console.WriteLine();
            Console.WriteLine("Deleting node 5");
            list.Delete(5);

            Console.WriteLine();
            Console.WriteLine("Position 5: " + list.Retrieve(5).NodeContent);

            Console.WriteLine();
            list.ListNodes();

            Console.ReadLine();*/

            //EXAMPLE3
            Console.WriteLine("Add First:");
            //Example3.LinkedList<string> myList1 = new Example3.LinkedList<string>();
            LinkedList myList1 = new Example3.LinkedList();
            //myList1.initilizeTheList();
            myList1.AddFirst("Hello");
            myList1.AddFirst(true);
            myList1.AddFirst(3);
            myList1.printAllNodes();



        }
    }

   
}