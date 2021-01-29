using System;
using System.Collections.Generic;

namespace Equality
{
    class Program
    {
        static void Main()
        {
            PointR r1 = new PointR { X = 100, Y = 200 };
            PointR r2 = new PointR { X = 100, Y = 200 };

       
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());

            //Console.WriteLine(c1.Equals(c2));

            PointS s1 = new PointS { X = 100, Y = 200 };
            PointS s2 = new PointS { X = 100, Y = 200 };

            //string str1 = "Hello";
            //string str2 = "Hello";

            //Console.WriteLine(str1.GetHashCode());
            //Console.WriteLine(str2.GetHashCode());

            PointC c1 = new PointC { X = 100, Y = 200 };
            PointC c2 = new PointC { X = 100, Y = 300 };


            Dictionary<PointC, string> dict = new Dictionary<PointC, string>();

            Console.WriteLine("Before add");

            dict.Add(c1, "c1");
            dict.Add(c2, "c2");

            PointC tester = new PointC { X = 100, Y = 400 };

              Console.WriteLine("Before lookup");

            if (dict.ContainsKey(tester))
                Console.WriteLine(dict[tester]);
            else
                Console.WriteLine("Not found");

            //string s = "Hello";

            //Console.WriteLine(s.GetHashCode());
        }
    }
}
