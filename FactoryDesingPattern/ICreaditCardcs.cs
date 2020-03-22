using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPattern
{
    public interface ICreaditCardcs
    {
        string GetCreditCardType();
        int GetCreditCardGetLimit();
        int GetCreditCardAnualCharge();
    }
}
