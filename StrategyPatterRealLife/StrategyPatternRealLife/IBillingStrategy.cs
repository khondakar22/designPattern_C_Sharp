using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternRealLife
{
   public interface IBillingStrategy
   {
       double GetActPrice(double rawPrice);
   }
}
