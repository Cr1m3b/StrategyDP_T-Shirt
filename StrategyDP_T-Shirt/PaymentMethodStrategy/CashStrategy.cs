using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.PaymentMethodStrategy
{
    public class CashStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 20000)
            {
                Console.WriteLine($"Paying {amount} using Cash declined.");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Cash accepted.");
                return true;
            }

        }
    }
}
