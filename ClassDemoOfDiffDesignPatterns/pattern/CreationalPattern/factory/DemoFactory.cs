namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory
{
    class DemoFactory
    {
        public static IDemoObject GetClass(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.Friendly: return new DemoObjectFriendly();
                case FactoryType.Polite: return new DemoObjectPolite();
            }

            return null;
        }
    }
}
