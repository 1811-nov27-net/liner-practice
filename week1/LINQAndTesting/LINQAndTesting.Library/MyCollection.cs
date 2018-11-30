using System;
using System.Collections.Generic;

namespace LINQAndTesting.Library
{
    /// <summary>
    /// a list with some extra helper methods 
    /// </summary>
    /// <remarks>
    /// two strategies we could use to leverage the builtin collection classes:
    /// - inheritance (MyCollection IS A List
    /// - composition (MyCollection HAS A List
    /// </remarks>
    public class MyCollection
    {
        // "readonly" just means I can't reassign "_list" to a different object
        // later. it doesn't mean I can't modify the object with its methods.
        private readonly List<string> _list = new List<string>();

        // ever class has at least one constructor
        // if you don't define one, it has a default constructor without any parameters
        //  "public MyCollection() {}"
        // but, as soon as you define any constructor, that default on will not be added.

        public void Sort()
        {
            _list.Sort();
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        // property without a "set"
        // calling code can say "coll.Length" instead of coll.GetLength()
        public int Length { get { return _list.Count;  } }

        public string Get(int index)
        {
            return _list[index];
        }

        public string Longest()
        {
            int longestLength = 0;
            string longest = null;
            foreach (var item in _list)
            {
                if (item != null && item.Length > longestLength)
                {
                    longestLength = item.Length;
                    longest = item;
                }
            }
            return longest;
        }
    }
}
