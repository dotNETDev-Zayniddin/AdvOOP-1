/*

Xaridor:
Xususiyatlar: Ism, mijoz hisob raqami.

*/

using System;
namespace ADVOOP
{
    class Customer
    {
        //ctor with name
        public string Name { get; set; } = string.Empty;
        public BankAccountNumber Account = new();

        public Customer(string name)
        {
            this.Name = name;
            Random random= new Random();
            Account.AccountNumber = random.Next(9996,9999);
        }
    }
}