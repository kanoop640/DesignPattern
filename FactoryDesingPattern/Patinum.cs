using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPattern
{
    class Patinum : ICreaditCardcs
    {
        public int GetCreditCardAnualCharge()
        {
            return 2000;
        }

        public int GetCreditCardGetLimit()
        {
            return 35000;
        }

        public string GetCreditCardType()
        {
            return "Platinum Plus";
        }
    }
}
