﻿using StrategyDP_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.VariationStrategy
{
    public interface IVariationStrategy
    {
        void Cost(TShirt Tshirt);
    }
}
