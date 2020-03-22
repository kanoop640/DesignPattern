using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesingPattern
{
    class Factory
    {
        public ICreaditCardcs GetCreditdCardDetails(string type)
        {
            switch (type)
            {
                case "MoneyBack":
                    return new MoneyBack();
                case "Titanium":
                    return new Titanium();
                case "Platinum":  return new Patinum();
                default:
                    Console.WriteLine("Wrong Credit cart type");
                    break;
            }
            return default;
        }
    }
}
