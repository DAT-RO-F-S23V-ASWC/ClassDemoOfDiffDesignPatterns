using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.singleton
{
    class NoteCatalogue
    {
        // Singleton starts
        private static NoteCatalogue _instance = new NoteCatalogue();

        public static NoteCatalogue Instance { get { return _instance; } }

        private NoteCatalogue()
        {
            this.notes = new List<string>()
            {
                "basic note1", "basic note2", "basic note3"
            };
        }
        // singleton ends

        private List<String> notes;

        public List<string> Notes => new List<string>(notes);



        public void Add(string item)
        {
            notes.Add(item);
        }

        public void Clear()
        {
            notes.Clear();
        }


        public override string ToString()
        {
            String strNotes = String.Join("\n", notes);
            return $"Notes are :\n{strNotes}";
        }
    }
}
