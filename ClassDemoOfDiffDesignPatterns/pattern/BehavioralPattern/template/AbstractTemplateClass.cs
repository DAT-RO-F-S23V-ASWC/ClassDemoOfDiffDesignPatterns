using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.template
{
    abstract class AbstractTemplateClass
    {
        private ICollection<String> _info;

        protected AbstractTemplateClass()
        {
            _info = new List<string>();
        }


        public void InsertTemplateMethod(ICollection<String> strings)
        {
            foreach (string s in strings)
            {
                // the template method use an abstract method to be overriden in subclass
                String str = MakeString(s);
                _info.Add(str);
            }
        }

        // the method to be overriden
        protected abstract string MakeString(string s);


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _info)}]";
        }
    }
}
