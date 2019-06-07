
namespace StrategyPatternRealLife
{
    class HappyHourStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice * 0.5;
        }
    }
}
