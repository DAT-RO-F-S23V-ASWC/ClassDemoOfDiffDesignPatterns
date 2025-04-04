namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    class DemoAdaptee1
    {
        // specific method of one class - can be mapped into the common interface
        public string KindOfPerson(string str)
        {
            if (str == "peter") return "teacher";

            return "student";
        }
    }
}
