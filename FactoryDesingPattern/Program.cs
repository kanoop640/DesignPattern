using System;

namespace FactoryDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Factory data = new Factory();
            var details=data.GetCreditdCardDetails("Titanium");
            Console.WriteLine(details.GetCreditCardType());
            Console.WriteLine(details.GetCreditCardGetLimit());
            Console.WriteLine(details.GetCreditCardAnualCharge());
        }
    }
}
