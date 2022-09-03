namespace LinkedLists
{
    class Program 
    {
        static void Main()
        {
            //ADDFIRST
            /*  Console.WriteLine("Add First:");
              LinkedList myList1 = new LinkedList();
              myList1.AddFirst("Item 1 is string: " + "Hello"); //string
              myList1.AddFirst("Item 2 is boolean: " + true); //boolean
              myList1.AddFirst("Item 3 is integer: " + 3); //integer
              myList1.printAllNodes();*/

            //ADDLAST
            Console.WriteLine();
            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();
            myList2.addLast("Item 1 is string: " + "Hello"); //string
            myList2.addLast("Item 2 is boolean: " + true); //boolean
           // myList2.addLast("Item 3 is integer: " + 3);
            myList2.printAllNodes();

            //REMOVEFIRST
         /*   Console.WriteLine();
            Console.WriteLine("Remove First:");
            LinkedList myList3 = new LinkedList();
            myList2.removeFirst();
            myList3.printAllNodes();*/

            //REMOVELAST
            Console.WriteLine();
            Console.WriteLine("Remove Last:");
            LinkedList myList4 = new LinkedList();
            myList2.removeLast();
            myList4.printAllNodes();

        }
    }   
}