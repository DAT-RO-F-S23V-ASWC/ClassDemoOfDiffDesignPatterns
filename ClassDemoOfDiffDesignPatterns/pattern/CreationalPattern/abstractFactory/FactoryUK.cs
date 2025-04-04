using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class FactoryUK:IFactory
    {
        public IDemoObject GetClass(FactoryType typeOfClass)
        {
            switch (typeOfClass)
            {
                case FactoryType.Friendly: return new DemoObjectFriendly();
                case FactoryType.Polite: return new DemoObjectPolite();
            }

            return new DemoObjectPolite();
        }
    }
}
