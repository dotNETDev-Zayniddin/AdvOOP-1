/*

Bank:
Usullari: mijoz uchun hisob ochish, mijozning hisobini yopish, 
hisoblar o'rtasida pul o'tkazish.

*/
using System;
using System.ComponentModel;
namespace ADVOOP
{
    class Bank
    {
        private List<Customer> customers = new();
        
        //Creating account with just Name
        public void CreateAccount(string name)
        {
            Customer newCustomer = new Customer(name); //Mijoz uchun hisob ochish
            var tempOBJ = customers.Find(x => x.Account.AccountNumber==newCustomer.Account.AccountNumber);
           //Condition When customer's Account number is found in the list it will regenerates
            if(tempOBJ == null)
            {
                customers.Add(newCustomer);
                System.Console.WriteLine($"Name: {newCustomer.Name}\nAccount Number: {newCustomer.Account.AccountNumber}");
                System.Console.WriteLine("Successful.");
            }
            else
            {
                System.Console.WriteLine("Looking for Account number for you. Please wait.");//There will be crash when list is fulfilled
                CreateAccount(name);
            }        
        }

        //removing account with Account Number. Because it is unique for every obj
        public void CloseAccount(long AccountNumber)
        {
            customers.Remove(customers.Find(c=>c.Account.AccountNumber == AccountNumber));
        }
        
        //Transfering between two accounts
        public void Transfer(decimal amount, long from, long to)
        {
            if(customers.Find(c=>c.Account.AccountNumber==from).Account.Balance >= amount)
            {
                customers.Find(c=>c.Account.AccountNumber==from).Account.Balance -= amount;
                customers.Find(c=>c.Account.AccountNumber==to).Account.Balance += amount;
                System.Console.WriteLine($"Done.\nNew balance: {customers.Find(c=>c.Account.AccountNumber==from).Account.Balance}");
            }
            else
            {
                System.Console.WriteLine("Insuffitient money in your balance");
            }
        }

        //Checking name and AccountNumber
        public bool IsAuthenticated(string name, long AccountNumber)
        {
            if(customers.Find((c=> c.Name == name && c.Account.AccountNumber == AccountNumber)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Getting Balance from Customer list
        public decimal GetCustomerBalance(long AccountNumber)
        {
            var temp = customers.Find(c=>c.Account.AccountNumber == AccountNumber);
            return (temp.Account.GetBalance());
        }
        
        //Deposit into authorised account
        public void Deposit(long AccountNumber, decimal amount)
        {
            var customer = customers.Find(c=>c.Account.AccountNumber == AccountNumber);
            customer.Account.Balance += amount;
            Console.WriteLine($"Successful.\nNew balance is {customer.Account.Balance}");
        }

        //Withdraw
        public void Withdraw(long AccountNumber, decimal amount)
        {
            var customer = customers.Find(c=>c.Account.AccountNumber == AccountNumber);
           if(customer.Account.Balance >= amount)
           {
                customer.Account.Balance -= amount;
                Console.WriteLine($"Succesful.\nNew Balance is {customer.Account.Balance}");
           }
           else
           {
                System.Console.WriteLine("Insuffient balance. Deposit first.");
           }
            
        }
       
        //Temporary Function for who tests this program
        public void Database()
        {
            System.Console.WriteLine("This temporary function for who tests this program");
            int i = 0;
                foreach(Customer customer in customers)
                {
                    i++;
                    System.Console.WriteLine($"{i}) Name: {customer.Name}\tAccount Number: {customer.Account.AccountNumber}\tBalance: {customer.Account.Balance}");
                }
        }
    }
}