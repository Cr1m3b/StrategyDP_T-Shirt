using StrategyDP_T_Shirt.Enums;
using StrategyDP_T_Shirt.EshopContext;
using StrategyDP_T_Shirt.Models;
using StrategyDP_T_Shirt.PaymentMethodStrategy;
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
            eshop.CalculateCost(shirt);
            

            Console.WriteLine("Choose payment method: ");
            Console.WriteLine("1- Bank Transfer");
            Console.WriteLine("2- Cash");
            Console.WriteLine("3- Debit Card");
            Console.WriteLine("4- Exit");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1": eshop.SetPaymentMethod(new BankTransferStrategy()); break;
                case "2": eshop.SetPaymentMethod(new CashStrategy()); break;
                case "3": eshop.SetPaymentMethod(new DebitCardStrategy()); break;
                case "4": Console.WriteLine("User exiting application"); ; break;
                default: Console.WriteLine("Invalid input"); break;

            }
            eshop.Discount(shirt, 0.5m);
            eshop.PayTShirt(shirt.Price);
        }
    }
}
