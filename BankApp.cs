/*

BankApp (Bank hisobini boshqarish uchun ariza):
Bir nechta mijozlar va hisoblar yarating.
Hisoblar o'rtasida pul o'tkazmalari.
Tranzaktsiyalardan keyin hisob balansini ko'rsatish.
*/

using System;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
namespace ADVOOP
{
    class BankApp
    {
        static void Main(string[] args)
        {
            Bank newBank = new Bank(); 
            System.Console.WriteLine("1. Kirish\n2. Ro'yxatdan o'tish");
            if(int.TryParse(Console.ReadLine(), out int option))
            {
                switch(option)
                {
                    case 1: 
                    {
                        Console.Write("Ism: ");
                        string Name = Console.ReadLine();
                        System.Console.WriteLine("Hisob raqami: ");
                        if(long.TryParse(Console.ReadLine(), out long AccountNumber))
                        {
                            if(newBank.isUserAuthorised(Name, AccountNumber))
                            {
                                System.Console.WriteLine("Hisobga kirish muvaffaqiyatli amalga oshdi");
                                System.Console.WriteLine("1. Hisobni tekshirish\n2. Depozit\n3. Pul yechib olish\n4. Transfer ");
                                System.Console.Write("Tanlov uchun raqam kirgizing: ");
                                if(int.TryParse(Console.ReadLine(), out int OptionMenu))
                                {
                                    switch(OptionMenu)
                                    {
                                        case 1:
                                        {
                                         newBank.GetCustomer(Name, AccountNumber);
                                         break;   
                                        }
                                    }
                                }
                            }
                        }
                    break;
                    }
                    case 2:
                    {
                        System.Console.Write("Ismingizni kiriting:");
                        string name = Console.ReadLine();
                        newBank.CreateAccount(name);
                        break;
                    }
                }
            }
        }
    }
}