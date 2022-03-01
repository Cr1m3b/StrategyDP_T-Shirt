using StrategyDP_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.PaymentMethodStrategy
{
    public interface IPaymentMethodStrategy
    {
        bool Pay(decimal amount);
        void Discount(TShirt Tshirt, decimal? amount);
    }
}
