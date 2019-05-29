namespace StrategyPattern
{
    internal class HighAltitudeFlying : IFlyBehavior
    {
        public string Fly()
        {
            return "High-altitude flying";
        }
    }
}