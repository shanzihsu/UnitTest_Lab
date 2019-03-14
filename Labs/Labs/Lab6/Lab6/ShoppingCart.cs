using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab6.Lab6
{
    public class ShoppingCart
    {
        public IDiscountRateFactory DiscountRateFactory { get; private set; }

        public ShoppingCart(IDiscountRateFactory discountRateFactory)
        {
            this.DiscountRateFactory = discountRateFactory;
        }

        public double Calculate(string level, double price)
        {
            var discountRate = this.DiscountRateFactory.GetDiscountRate(level);
            var finalPrice = price * discountRate;

            return finalPrice;
        }
    }
}
