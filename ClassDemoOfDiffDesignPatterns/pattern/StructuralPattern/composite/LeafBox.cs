namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.composite
{
    public class LeafBox:IComponent
    {
        public int Weight { get; set; }

        public LeafBox():this(0)
        {
        }

        public LeafBox(int weight)
        {
            Weight = weight;
        }

        // from interface
        public int TotalWeight()
        {
            return Weight;
        }
    }
}
