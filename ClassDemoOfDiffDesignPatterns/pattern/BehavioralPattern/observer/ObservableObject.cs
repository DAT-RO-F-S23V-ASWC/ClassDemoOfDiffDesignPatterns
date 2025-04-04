using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassDemoOfDiffDesignPatterns.Annotations;

namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.observer
{
    class ObservableObject:INotifyPropertyChanged
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
                Notify("Id");
                
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text) return;
                _text = value;
                Notify("Text");
                }
        }



        /*
         * Observer support
         */
        public event PropertyChangedEventHandler PropertyChanged;

        public void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Text)}: {Text}";
        }

    }
}
