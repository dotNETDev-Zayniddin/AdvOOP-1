/*

Xaridor:
Xususiyatlar: Ism, mijoz hisob raqami.

*/

using System;
namespace ADVOOP
{
    class Customer
    {
       public string Name{ get; private set; }
       public BankAccountNumber BankAccount{ get; private set; }

       public Customer(string Name)
       {
        this.Name = Name;
        Random random= new Random();
        BankAccount.AccountNumber = (long) random.Next(100,999);
        System.Console.WriteLine(BankAccount);

       }
    }
}