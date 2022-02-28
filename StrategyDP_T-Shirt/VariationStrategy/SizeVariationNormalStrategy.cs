using StrategyDP_T_Shirt.Enums;
using StrategyDP_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.VariationStrategy
{
    public class SizeVariationNormalStrategy : IVariationStrategy
    {
        //Timokatalogos
        private static Dictionary<Size, decimal> sizeVariation;

        static SizeVariationNormalStrategy()
        {
            sizeVariation = new Dictionary<Size, decimal>()
            {
                {Size.XS,2m },
                {Size.S,3m },
                {Size.M,4m },
                {Size.L,5m },
                {Size.XL,6m },
                {Size.XXL,7m },
                {Size.XXXL,8m }
            };
        }

        public void Cost(TShirt Tshirt)
        {
            Tshirt.Price += sizeVariation[Tshirt.Size];
        }
    }
}
