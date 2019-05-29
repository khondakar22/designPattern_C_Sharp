namespace StrategyPattern
{
    internal class CalmFlying : IFlyBehavior
    {
        public string Fly()
        {
            return "Flying Calmly";
        }
    }
}