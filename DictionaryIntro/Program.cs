using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities2 = new MyDictionary<int, string>();
            cities2.Add(34, "Istanbul");
            cities2.Add(06, "Ankara");
            cities2.Add(07, "Antalya");
          
        }
    }
}
