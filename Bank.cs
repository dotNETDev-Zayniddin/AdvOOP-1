/*

Bank:
Usullari: mijoz uchun hisob ochish, mijozning hisobini yopish, 
hisoblar o'rtasida pul o'tkazish.

*/
using System;
namespace ADVOOP
{
    class Bank
    {
        private List <Customer> customers = new List<Customer>(); // Ma'lumotlarni Saqlash uchun
       
        public bool isUserAuthorised(string Name, long AccountNumber)
        
        {
             var customer = customers.Find(c => c.Name == Name && c.BankAccount.AccountNumber == AccountNumber);
            if(customer != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void CreateAccount(string Name)
        {
            Customer customer = new Customer(Name);
            customers.Add(customer);
        }
        public Customer GetCustomer(string Name, long AccountNumber)
        {
            return customers.Find(c => c.Name == Name && c.BankAccount.AccountNumber == AccountNumber);
        }


    }
}