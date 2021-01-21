using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(34, "Istanbul");
            cities.Add(06, "Ankara");
            cities.Add(07, "Antalya");
          
        }
    }
}
