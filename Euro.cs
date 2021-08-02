using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDataBase
{
    public class Euro : CurrencyType
    {
        public Euro()
        {
            PriceCurrency = 1.19f;
            NameCurrency = "Евро";
        }
    }
}
