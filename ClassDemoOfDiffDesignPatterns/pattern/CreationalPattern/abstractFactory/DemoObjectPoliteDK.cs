using System;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectPoliteDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Kære {name}");
        }
    }
}
