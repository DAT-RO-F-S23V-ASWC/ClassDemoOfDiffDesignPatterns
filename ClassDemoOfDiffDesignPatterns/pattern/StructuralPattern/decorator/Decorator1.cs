using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    class Decorator1:IComponent
    {
        // reference to the object to decorate / wrap 

        private IComponent _component;

        public Decorator1(IComponent component)
        {
            _component = component;
        }


        public string DoSomething(string str)
        {
            return " Weekend Now! " + _component.DoSomething(str);
        }
    }
}
