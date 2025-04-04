using System;

namespace ClassDemoOfDiffDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternWorker worker = new PatternWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
