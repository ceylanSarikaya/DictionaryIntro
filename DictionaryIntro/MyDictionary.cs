using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

       
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value) 
        {
            TKey[] tempKeyArray = keys;
            TValue[] tempValueArray = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

    }
}
