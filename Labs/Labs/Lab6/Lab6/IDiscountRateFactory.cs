﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab6.Lab6
{
    public interface IDiscountRateFactory
    {
        double GetDiscountRate(string level);
    }
}
