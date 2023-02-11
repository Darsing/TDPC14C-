using System;
using System.Collections.Generic;
using System.Linq;

namespace list100223
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> list = new List<int>();
            list.Add(1);    
            list.Add(2);    
            list.Add(3);
            list.Add(4); 
            list.Add(5);

            //esempi di remove con value
            list.Remove(4);
            //esempi di remove in position 1
            list.Remove(list[1]);
            //list.Remove(list.ElementAt(1));

            foreach(int l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}
