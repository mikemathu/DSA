using MyHashing;
using System.Collections;

namespace MyHashing
{
    class program
    {
        static void Main(string[] args)
        {
            /*string s = "My name is Mike";
            char c = s[6];
            Console.WriteLine("Char Output =>" + c);

            //Unicode output
            int i = s[6];
            Console.WriteLine("Int Output =>" + i);*/

            /*string s = "My name is Mik";

            MyHashcodestring hashString = new MyHashcodestring();

            hashString.hashCode(s);*/

            /*  HashTable h = new HashTable(2);
              h.set("grapes", 1000);
              h.set("apples", 54);
              Console.Write(h.get("apples"));
              h.keys();*/


            int[] arr = { 1, 5, 8, 5, 1, 8, 8, 7, 4, 4, 10 };
            Console.Write(FindFirstRecurringChar(arr));


        }

        static int FindFirstRecurringChar(int[] arr)
        {
            Hashtable h = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if (h.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                h[arr[i]] = arr[i];
            }
            return 0;
        }


    }
}