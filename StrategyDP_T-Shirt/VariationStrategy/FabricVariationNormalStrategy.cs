using StrategyDP_T_Shirt.Enums;
using StrategyDP_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.VariationStrategy
{
    public class FabricVariationNormalStrategy : IVariationStrategy
    {
        //Timokatalogos
        private static Dictionary<Fabric, decimal> fabricVariation;

        static FabricVariationNormalStrategy()
        {
            fabricVariation = new Dictionary<Fabric, decimal>()
            {
                {Fabric.CASHMERE,3m },
                {Fabric.COTTON,4m },
                {Fabric.LINEN,6m },
                {Fabric.POLYESTER,12m },
                {Fabric.RAYON,15m },
                {Fabric.SILK,18m },
                {Fabric.WOOL,20m }
            };
        }

        public void Cost(TShirt Tshirt)
        {
            Tshirt.Price += fabricVariation[Tshirt.Fabric];
        }

        
    }
}
