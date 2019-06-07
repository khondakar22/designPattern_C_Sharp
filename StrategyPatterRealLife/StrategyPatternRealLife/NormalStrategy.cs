using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternRealLife
{
    class NormalStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice)
        {
            return rawPrice;
        }
    }
}
