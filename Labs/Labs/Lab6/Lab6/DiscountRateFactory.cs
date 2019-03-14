using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab6.Lab6
{
    public class DiscountRateFactory : IDiscountRateFactory
    {
        public ILevelRepository LevelRepository { get; private set; }

        public DiscountRateFactory(ILevelRepository levelRepository)
        {
            this.LevelRepository = levelRepository;
        }

        public double GetDiscountRate(string level)
        {
            var shouldDiscount = this.LevelRepository.HaveDiscount(level);

            if (shouldDiscount)
            {
                return 0.8;
            }

            return 1;
        }
    }
}
