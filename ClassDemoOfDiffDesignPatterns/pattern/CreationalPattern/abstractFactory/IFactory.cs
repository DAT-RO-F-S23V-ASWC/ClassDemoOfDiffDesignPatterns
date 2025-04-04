using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    interface IFactory
    {
        IDemoObject GetClass(FactoryType typeOfClass);
    }
}
