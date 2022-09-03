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
            /*      Console.WriteLine();
                  Console.WriteLine("Add Last:");
                  LinkedList myList2 = new LinkedList();
                  myList2.addLast("Item 1 is string: " + "mike"); //string
                  myList2.addLast("Item 2 is boolean: " + true); //boolean
                  myList2.addLast("Item 3 is integer: " + 3);
                  myList2.printAllNodes();*/

            //REMOVEFIRST
            /*   Console.WriteLine();
               Console.WriteLine("Remove First:");
               LinkedList myList3 = new LinkedList();
               myList2.removeFirst();
               myList3.printAllNodes();*/

            //REMOVELAST
            /*        Console.WriteLine();
                    Console.WriteLine("Remove Last:");
                    LinkedList myList4 = new LinkedList();
                    myList2.removeLast();
                    myList4.printAllNodes();*/

            //REMOVE
            /*   Console.WriteLine();
               Console.WriteLine("Before Remove :");
               LinkedList myList5 = new LinkedList();
               myList5.addLast("Item 1 is string: " + "mike"); //string
               myList5.addLast("Item 2 is boolean: " + true); //boolean
               myList5.addLast("Item 3 is integer: " + 3); //integer
               myList5.printAllNodes();

               Console.WriteLine();
               Console.WriteLine("After Remove :");
               myList5.remove("Item 2 is boolean: " + true);
               myList5.printAllNodes();*/

            //CONTAIN
            /*   Console.WriteLine();
               Console.WriteLine("Add Last :");
               LinkedList myList6 = new LinkedList();
               myList6.addLast("Item 1 is string: " + "mike"); //string
               myList6.addLast("Item 2 is boolean: " + true); //boolean
               myList6.addLast("Item 3 is integer: " + 3); //integer

               Console.WriteLine();
               Console.WriteLine("Contain :");
               myList6.contain("Item 2 is boolean: ");*/

            /*   //PEEKLAST
               Console.WriteLine();
               Console.WriteLine("Add Last :");
               LinkedList myList7 = new LinkedList();
               myList7.addLast("Item 2 is boolean: " + true); //boolean
               myList7.addLast("Item 1 is string: " + "mike"); //string            
               myList7.addLast("Item 3 is integer: " + 3); //integer
               myList7.printAllNodes();

                Console.WriteLine();
               Console.WriteLine("Peek First :");
               myList7.peekFirst();*/


            //PEEKLAST
            Console.WriteLine();
            Console.WriteLine("Add Last :");
            LinkedList myList8 = new LinkedList();
            myList8.addLast("Item 2 is boolean: " + true); //boolean                
            myList8.addLast("Item 3 is integer: " + 3); //integer
            myList8.addLast("Item 1 is string: " + "mike"); //string     
            myList8.printAllNodes();

            Console.WriteLine();
            Console.WriteLine("Peek Last :");
            myList8.peekLast();


        }
    }   
}