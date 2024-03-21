using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MyDictionary<TKey,TValue>
    {
        private Dictionary<TKey, TValue> dictionary;

        public MyDictionary()
        {
            dictionary = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get { return dictionary[key]; }
        }

        public int Count
        {
            get { return dictionary.Count; }
        }
    }
}
