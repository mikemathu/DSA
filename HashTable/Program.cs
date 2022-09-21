using System.Collections;

/*namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Int16> Dict = new Dictionary<string, Int16>();
            Dict.Add("Cart", 32);
            Dict.Add("Dog", 25);
            Dict.Add("Tree", 29);
            Dict.Add("Allow", 21);

            //Console.WriteLine("Count: {0}", Dict.Count);
            Dict["Tree"] = 9; //change tree from 29 to 9
            //Console.WriteLine(Dict["tree"]);

            if (Dict.ContainsKey("Dog"))
            {
                Dict["Dog"] = 20;
            }
            //Console.WriteLine(Dict["Dog"]);
            if (Dict.ContainsValue(9))
            {
                //Console.WriteLine("Item found");                
            }

            //All items
            Console.WriteLine("All Words");
            foreach(KeyValuePair<string, Int16> word in Dict)
            {
                Console.WriteLine("Key: {0}, value: {1}", word.Key, word.Value);
            }

            //Remove
            Dict.Remove("Tree");
            Console.WriteLine();
            Console.WriteLine("Tree Removed");
            foreach (KeyValuePair<string, Int16> word in Dict)
            {
                Console.WriteLine("Key: {0}, value: {1}", word.Key, word.Value);
            }

            

        }
    }
}
*/
namespace Hashtablee
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Htable = new Hashtable();
            Htable.Add(1, "c");
            Htable.Add(3, "a");
            Htable.Add(4, "s");
            Htable.Add(2, "r");
            Htable.Add(5, "h");

            foreach (object i in Htable.Keys)
                //Console.WriteLine(i);
                foreach (object j in Htable.Values)
                    //Console.Write(j);
            /*foreach (DictionaryEntry dic in Htable)
                Console.WriteLine("Keys ={0} values = {1}", dic.Key, dic.Value);
            Console.ReadKey();*/
        }
    }
}