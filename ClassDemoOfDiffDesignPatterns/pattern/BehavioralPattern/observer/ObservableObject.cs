using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassDemoOfDiffDesignPatterns.Annotations;

namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.observer
{
    class ObservableObject
    {
        private int _id;
        private String _text;

        
        public ObservableObject(int id, string text)
        {
            _id = id;
            _text = text;
        }

        public ObservableObject()
        {
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value == _id) return;
                _id = value;
                
                
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                
                }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Text)}: {Text}";
        }

    }
}
