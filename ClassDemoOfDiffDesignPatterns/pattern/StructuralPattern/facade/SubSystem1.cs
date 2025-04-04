using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.facade
{
    class SubSystem1
    {
        private List<String> noter = new List<string>();
        public String GetNote(int ix)
        {
            if (0 <= ix && ix < noter.Count)
            {
                return noter[ix];
            }

            throw new ArgumentException("ix not found");
        }

        public void InsertNote(String note)
        {
            noter.Add(note);
        }
    }
}

