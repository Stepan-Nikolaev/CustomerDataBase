using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDataBase
{
    public class Account
    {
        public int CountMoney;
        public CurrencyType ClientCurrent;

        public void DisplayAccount()
        {
            Console.WriteLine(CountMoney);
            Console.WriteLine(ClientCurrent.NameCurrency);
        }
    }
}
