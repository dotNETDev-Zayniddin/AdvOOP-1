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
            public long  AccountNumber { get; set; }
            public decimal Balance { get; set; }

            public BankAccountNumber()
            {
                Balance = 0;
            }
        
            public decimal GetBalance()
            {
                return Balance;
            }
            
        }         
}