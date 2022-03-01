using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP_T_Shirt.PaymentMethodStrategy
{
    public class BankTransferStrategy : IPaymentMethodStrategy
    {
        public bool Pay(decimal amount)
        {
            if (amount<0m||amount>10000)
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer declined.");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Bank Transfer accepted.");
                return true;
            }
            
        }
    }
}
