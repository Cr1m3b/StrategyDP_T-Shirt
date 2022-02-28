using StrategyDP_T_Shirt.Models;
using StrategyDP_T_Shirt.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.EshopContext
{
    public class EShop
    {
        private IEnumerable<IVariationStrategy> variations;

        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }

        public void PayTShirt(TShirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
            }
            Console.WriteLine($"The final cost of your T-Shirt is: {shirt.Price} €");
        }
    }
}
