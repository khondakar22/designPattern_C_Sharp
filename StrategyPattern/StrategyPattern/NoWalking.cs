namespace StrategyPattern
{
    internal class NoWalking : IWalkBehavior
    {
        public string Walk()
        {
            return "No Walking";
        }
    }
}