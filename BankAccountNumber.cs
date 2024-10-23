    /* 

    Bank hisobini boshqarish
    Ob'ektga yo'naltirilgan dasturlash tamoyillaridan foydalangan 
    holda bank hisobini boshqarish dasturini yarating. 
    Quyidagi sinflarni amalga oshiring:

    Bank hisob raqami:
    Xususiyatlari: Hisob raqami, Balans.
    Usullari: Depozit qo'yish, Pul yechib olish, Balansni olish.

    */
    using System;
    namespace ADVOOP
    {
        class BankAccountNumber
        {
           public long AccountNumber {get;  set;}
           public decimal Balance {get;set;}
           
           public BankAccountNumber(long accountNumber)
           {
            this.AccountNumber = accountNumber;
           }
           public void Deposit(decimal amount)
           {
            Balance = Balance + amount;
            System.Console.WriteLine($"Deposit was succesfully. Balance: {Balance}");
           }

           public void Withdraw(decimal amount)
           {
             if(Balance >= amount)
             {
                Balance = Balance - amount;
                System.Console.WriteLine($"Withdraw was succesfully. Balance: {Balance}");
             }
             else
             {
                System.Console.WriteLine($"Insufficient balance. Balance: {Balance}");
             }
           }
           public void GetBalance()
           {
            System.Console.WriteLine($"Balance: {Balance}");
           }
        }
    }