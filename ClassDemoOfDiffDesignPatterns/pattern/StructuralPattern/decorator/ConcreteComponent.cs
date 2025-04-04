using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    class ConcreteComponent : IComponent
    {
        public String DoSomething(string str)
        {
            // do nothing else but return the string

            return str;
        }
    }
}
