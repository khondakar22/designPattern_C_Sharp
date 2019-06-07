using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternRealLife
{
    public class Customer
    {
        private readonly IList<double> _drinks;
        public IBillingStrategy Strategy { get; set; }

        public Customer(IBillingStrategy strategy )
        {
            Strategy = strategy;
            this._drinks = new List<double>();
        }

        public void Add(double price, int quantity)
        {
            this._drinks.Add(this.Strategy.GetActPrice(price*quantity));
        }

        public void PrintBill()
        {
            double sum = 0;
            foreach (double i in this._drinks)
            {
                sum += i;
            }

            Console.WriteLine("Total due: " + sum);
            this._drinks.Clear();
        }
    }

}
