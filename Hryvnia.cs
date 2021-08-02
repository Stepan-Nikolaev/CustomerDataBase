using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDataBase
{
    public class Hryvnia : CurrencyType
    {
        public Hryvnia()
        {
            PriceCurrency = 0.037f;
            NameCurrency = "Гривна";
        }
    }
}
