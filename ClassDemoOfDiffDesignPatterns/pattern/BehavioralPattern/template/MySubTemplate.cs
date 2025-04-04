namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.template
{
    class MySubTemplate:AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {
            return s.ToLower();
        }
    }
}
