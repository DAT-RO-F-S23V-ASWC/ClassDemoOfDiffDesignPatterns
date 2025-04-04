using System;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectPolite:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Dear {name}");
        }
    }
}
