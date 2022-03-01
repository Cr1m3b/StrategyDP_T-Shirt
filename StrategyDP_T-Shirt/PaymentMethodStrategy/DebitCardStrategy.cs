using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.PaymentMethodStrategy
{
    public class DebitCardStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount < 0m || amount > 15000)
            {
                Console.WriteLine($"Paying {amount} using Debit Card declined.");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Debit Card accepted.");
                return true;
            }

        }
    }
}
