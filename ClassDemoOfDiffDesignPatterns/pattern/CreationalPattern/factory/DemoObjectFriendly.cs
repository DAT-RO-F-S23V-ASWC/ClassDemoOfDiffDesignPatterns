using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory
{
    class DemoObjectFriendly:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
