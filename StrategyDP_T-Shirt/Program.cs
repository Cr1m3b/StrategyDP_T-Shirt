using StrategyDP_T_Shirt.Enums;
using StrategyDP_T_Shirt.EshopContext;
using StrategyDP_T_Shirt.Models;
using StrategyDP_T_Shirt.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IVariationStrategy> ShopNormalVariations = new List<IVariationStrategy>()
            {
                new ColorVariationNormalStrategy(),
                new FabricVariationNormalStrategy(),
                new SizeVariationNormalStrategy()
            };

            TShirt shirt = new TShirt(Color.BLUE, Fabric.CASHMERE, Size.XL);

            var eshop = new EShop();
            eshop.SetVariation(ShopNormalVariations);
            eshop.PayTShirt(shirt);
        }
    }
}
