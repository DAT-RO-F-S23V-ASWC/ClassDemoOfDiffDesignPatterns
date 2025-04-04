namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state
{
    class DemoStateLow:IState
    {
        public int HandleCalculate(int priceExTax)
        {
            return (int) (priceExTax * 1.10);
        }
    }
}
