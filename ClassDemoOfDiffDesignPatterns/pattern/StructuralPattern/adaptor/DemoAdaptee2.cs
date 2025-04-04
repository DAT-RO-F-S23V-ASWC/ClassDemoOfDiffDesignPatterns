namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    class DemoAdaptee2
    {
        // specific method of one class - can be mapped into the common interface
        public string Upper(string str)
        {
            return str.ToUpper();
        }
    }
}
