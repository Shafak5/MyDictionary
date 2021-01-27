using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<KeyType, ValueType>
    {
        KeyType[] keys;
        ValueType[] values;
        public MyDictionary()
        {
            keys = new KeyType[0];
            values = new ValueType[0];
        }
        public void Add(KeyType item, ValueType item2)
        {
            KeyType[] tempKeyArray = keys;
            ValueType[] tempValueArray = values;

            keys = new KeyType[tempKeyArray.Length + 1];
            values = new ValueType[tempValueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
            }
            for (int j = 0; j < tempValueArray.Length; j++)
            {
                values[j] = tempValueArray[j];
            }
            keys[keys.Length - 1] = item;
            values[values.Length - 1] = item2;
        }
        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ":" + values[i]);
            }
        }


    }

}
