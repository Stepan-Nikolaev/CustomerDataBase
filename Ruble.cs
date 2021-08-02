using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDataBase
{
    public class Ruble : CurrencyType
    {
        public Ruble()
        {
            PriceCurrency = 0.014f;
            NameCurrency = "Рубль";
        }
    }
}
