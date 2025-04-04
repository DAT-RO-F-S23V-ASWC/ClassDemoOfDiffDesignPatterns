using System;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectFriendly:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
