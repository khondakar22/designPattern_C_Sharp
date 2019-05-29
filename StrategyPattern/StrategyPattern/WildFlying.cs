namespace StrategyPattern
{
   
    internal class WildFlying : IFlyBehavior
    {
        public string Fly()
        {
            return "Flying Wildly";
        }
    }
}