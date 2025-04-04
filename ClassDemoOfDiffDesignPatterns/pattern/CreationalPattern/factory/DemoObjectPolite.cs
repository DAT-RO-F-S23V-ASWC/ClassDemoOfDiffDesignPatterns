using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory
{
    class DemoObjectPolite:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Dear {name}");
        }
    }
}
