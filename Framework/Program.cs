using System;

namespace Framework
{
    class Program
    {
        static void Main()
        {
            string s1 = new string(new char[] { (char)0, (char)61250, (char)46207 });
            string s2 = "AA";

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
