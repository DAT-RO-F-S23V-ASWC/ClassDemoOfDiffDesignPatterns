namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class AbstractFactory
    {
        public static IFactory GetFactory(AbstractFactoryType typeOfFactory)
        {
            // get a factory depending om the parameter
            switch (typeOfFactory)
            {
                case AbstractFactoryType.Dk: return new FactoryDK();
                case AbstractFactoryType.Uk: return new FactoryUK();

            }

            return new FactoryUK();
        }
    }
}
