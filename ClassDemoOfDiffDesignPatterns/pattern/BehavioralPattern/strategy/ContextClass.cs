using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.strategy
{
    class ContextClass
    {
        private ICollection<String> _collection;

        public ContextClass()
        {
            _collection = new List<string>();
        }


        // dependency inject of object
        public void InsertStrategyMethod(ICollection<String> strings, IStrategy obj)
        {
            foreach (string s in strings)
            {
                // the strategy method in the obj of the contract of IStrategy 
                String str = obj.MakeString(s);
                _collection.Add(str);
            }
        }


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _collection)}]";
        }
    }
}
