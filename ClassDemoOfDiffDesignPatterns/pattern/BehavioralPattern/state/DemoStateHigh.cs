namespace ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state
{
    class DemoStateHigh : IState
    {
        public int HandleCalculate(int priceExTax)
        {
            return (int)(priceExTax * 1.25);
        }
    }
}
