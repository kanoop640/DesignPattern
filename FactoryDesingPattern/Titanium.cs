using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPattern
{
    class Titanium : ICreaditCardcs
    {
        public int GetCreditCardAnualCharge()
        {
            return 1500;
        }

        public int GetCreditCardGetLimit()
        {
            return 25000;
        }

        public string GetCreditCardType()
        {
            return "Titanium Edge";
        }
    }
}
