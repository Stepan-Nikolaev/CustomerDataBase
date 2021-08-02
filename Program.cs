using System;
using System.Collections.Generic;

namespace CustomerDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            List<Client> ClientsDataBase = new List<Client>();
            Dictionary<Client, List<Account>> clients = new Dictionary<Client, List<Account>>()
            {
                {new Client {Name = "1", Surname = "1", Patronymic = "1", AccountNumber = 1, PassportID = 1}, new List<Account>()
                {
                    new Account() {CountMoney = 100, ClientCurrent = new Ruble() },
                    new Account() {CountMoney = 500, ClientCurrent = new Euro() }
                }
                },
                {new Client {Name = "2", Surname = "2", Patronymic = "2", AccountNumber = 2, PassportID = 2}, new List<Account>()
                {
                    new Account() {CountMoney = 200, ClientCurrent = new Euro() },
                    new Account() {CountMoney = 300, ClientCurrent = new Hryvnia() }
                }
                },
                {new Client {Name = "3", Surname = "3", Patronymic = "3", AccountNumber = 3, PassportID = 3}, new List<Account>()
                {
                    new Account(){CountMoney = 300, ClientCurrent = new Hryvnia() },
                    new Account(){CountMoney = 1000, ClientCurrent = new Hryvnia()}
                }
                }
            };
        }

        static Client AddClient()
        {
            Client newClient = new Client();

            Console.Clear();
            Console.WriteLine("Пожалуйста, введите ваше имя");
            newClient.Name = Console.ReadLine();
            Console.WriteLine("Пожалуйста, ввеедите вашу фамилию");
            newClient.Surname = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите ваше отчество");
            newClient.Patronymic = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите, сколько денег у вас на счету");
            newClient.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите номер вашего паспорта");
            newClient.PassportID = Convert.ToInt32(Console.ReadLine());

            return newClient;
        }

        static double ConverterCurrency(int countMoney, CurrencyType firstCurrency, CurrencyType secondCurrency)
        {
            return (countMoney * firstCurrency.PriceCurrency) / secondCurrency.PriceCurrency;
        }
    }
}
