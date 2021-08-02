using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDataBase
{
    public abstract class CurrencyType
    {
        public float PriceCurrency { get; set; }
        public string NameCurrency { get; set; }
    }
}
