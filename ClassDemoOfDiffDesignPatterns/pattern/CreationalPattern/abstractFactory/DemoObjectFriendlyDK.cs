using System;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectFriendlyDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hej {name}");
        }
    }
}
