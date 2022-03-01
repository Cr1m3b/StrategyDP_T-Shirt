using StrategyDP_T_Shirt.Models;
using StrategyDP_T_Shirt.PaymentMethodStrategy;
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
        private IPaymentMethodStrategy paymentMethods;

        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }
        public void SetPaymentMethod(IPaymentMethodStrategy paymentMethod)
        {
            paymentMethods = paymentMethod;
        }
        public void CalculateCost(TShirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
            }

            Console.WriteLine($"The final cost of your T-Shirt is: {shirt.Price} Euros");
        }

        public void PayTShirt(decimal price)
        {
            

            if (paymentMethods.Pay(price))
            {
                Console.WriteLine("Transaction succesfull");
            }
            else
            {
                Console.WriteLine("Transaction declined");
            }


        }



    }
}
