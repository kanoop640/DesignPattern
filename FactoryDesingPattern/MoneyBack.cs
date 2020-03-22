using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPattern
{
    class MoneyBack : ICreaditCardcs
    {
        public int GetCreditCardAnualCharge()
        {
            return 500;
        }

        public int GetCreditCardGetLimit()
        {
            return 15000;
        }

        public string GetCreditCardType()
        {
            return "MoneyBack";
        }
    }
}
