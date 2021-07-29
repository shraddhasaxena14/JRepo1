using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEg
{
    class CollectionDemo
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("Devi");
            al.Add(100.0f);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add('a');
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("Capacity {0}", al.Capacity);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine("Count is {0}", al.Count);
            Console.WriteLine("Index of {0} is", al.IndexOf(20));
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Remove("Devi");
            al.Remove(20);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }

            Console.WriteLine("Capacity {0}", al.Capacity);

        }

        //Combination of key and value

        static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("N", "Networks");
            ht.Add("O", "Operating System");
            ht.Add("J", "Java");
            ht.Add("U", "Unix");
            Console.WriteLine(ht.Contains("O"));
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ";" + d.Value);
            }
        }
        static void SortedListEg()
        {
            SortedList sl = new SortedList();
            sl.Add("N", "Networks");
            sl.Add("O", "Operating System");
            sl.Add("J", "Java");
            sl.Add("U", "Unix");
            Console.WriteLine(sl.Contains("O"));
            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + ";" + d.Value);
            }
        }
        static void Main()
        {
            ArrayEg();
            Console.WriteLine("HashTable");
            HashtableEg();
            Console.WriteLine("SortedList");
            SortedListEg();
        }
    }
}
