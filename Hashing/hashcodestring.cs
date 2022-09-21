namespace MyHashing
{
    class MyHashcodestring
    {
        //hashCode strings  
        public int hashCode(string s)
        {
            int g = 31;
            int hash = 0;
            for (int i = 0; i < s.Length; i++)
                hash = g * hash + s[i];

            Console.WriteLine("This is hash => " + hash);
            return hash;
        }

    }
}
