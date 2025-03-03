﻿using StrategyDP_T_Shirt.Enums;
using StrategyDP_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.VariationStrategy
{
    public class ColorVariationNormalStrategy : IVariationStrategy
    {
        //Timokatalogos
        private static Dictionary<Color, decimal> colorVariation;

        static ColorVariationNormalStrategy()
        {
            colorVariation = new Dictionary<Color, decimal>()
            {
                {Color.BLUE,1m },
                {Color.GREEN,2m },
                {Color.INDIGO,4m },
                {Color.ORANGE,5m },
                {Color.RED,8m },
                {Color.VIOLET,12m },
                {Color.YELLOW,20m }
            };
        }

        public void Cost(TShirt Tshirt)
        {
            Tshirt.Price += colorVariation[Tshirt.Color];
        }

        
    }
}
