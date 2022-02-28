using StrategyDP_T_Shirt.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.Models
{
    public class Tshirt
    {
        public Color Color;
        public Fabric Fabric;
        public Size Size;
        public decimal Price { get; set; }
        public Tshirt(Color color, Fabric fabric, Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

    }
}
