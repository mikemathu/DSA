namespace LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {

        private ListNode head;
        private ListNode tail;

        //public ListNode RemoveElements(ListNode head, int val)
            public ListNode RemoveElements()
        {
            //int[] arr = head;
            //int data = val;
            int[] arr = { 1, 2, 6, 4, 5, 6 };
            int data = 6;

           for(int i = 0; i < arr.Length; i++)
            {
                ListNode node = new ListNode(data);
                node.next = head;
                head = node;

                ListNode current = head;
                ListNode previous = null;
                while (current != null)
                {
                    if (arr[i].Equals(data))
                    {
                        //Object nodeData = current.data;
                        //int nodeData = arr[i];
                        if (current.next != null){
                            previous = current.next;                          
                        }
                        else
                        {
                            previous = null;                           
                        }
                    }
                    previous = current;
                    current = current.next;
                    
                }
            }
            Console.WriteLine(" " + String.Join(",", arr));



            return head;


              
    }

    }
}
