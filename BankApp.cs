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
        public static void Main()
        {
            Bank bank = new Bank();
            
            Console.Clear();
            while(true)
            {                
                System.Console.WriteLine("1.Create Account");
                System.Console.WriteLine("2.Open Account");
                System.Console.WriteLine("3.List of users");

                if(int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.Clear();
                    switch(option)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("Enter your name to generate Account Number:");
                            string input = Console.ReadLine();
                            bank.CreateAccount(input);
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("Enter your name:");
                            string tempName = Console.ReadLine();
                            System.Console.WriteLine("Enter your Account number");
                            if(long.TryParse(Console.ReadLine(), out long tempAccountNumber))
                            {
                                bool isVerified = bank.IsAuthenticated(tempName, tempAccountNumber);
                                if(tempName!=null && isVerified )
                                {
                                    Console.Clear();
                                    System.Console.WriteLine("Login was successfull.");
                                    System.Console.WriteLine($"Your Balance is {bank.GetCustomerBalance(AccountNumber: tempAccountNumber)}");
                                   
                                    bool isOver = false;
                                    while(!isOver)
                                    {          
                                        System.Console.WriteLine("Select option:");
                                        System.Console.WriteLine("1. Deposit");
                                        System.Console.WriteLine("2. Withdraw");
                                        System.Console.WriteLine("3. Balance");
                                        System.Console.WriteLine("4. Transfer");
                                        System.Console.WriteLine("5. Exit");
                                     
                                        if(int.TryParse(Console.ReadLine(), out int option1))
                                        {
                                            switch(option1)
                                            {
                                                case 1:
                                                {
                                                    System.Console.WriteLine("How much you want to deposit?");
                                                    if(decimal.TryParse(Console.ReadLine(), out decimal amount))
                                                    {
                                                        bank.Deposit(tempAccountNumber, amount);
                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Input was wrong!");
                                                    }
                                                    break;
                                                }
                                                case 2:
                                                {
                                                    System.Console.WriteLine("How much you want to withdraw?");
                                                    if(decimal.TryParse(Console.ReadLine(), out decimal amount))
                                                    {
                                                        bank.Withdraw(tempAccountNumber, amount);
                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Input was wrong!");
                                                    }
                                                    break;
                                                }
                                                case 3:
                                                {
                                                    Console.WriteLine($"Your balance is {bank.GetCustomerBalance(tempAccountNumber)}");
                                                    break;
                                                }
                                                case 4:
                                                {
                                                    System.Console.Write("Where to want to transfer?\nEnter an Account Number to transfer: ");
                                                    if(long.TryParse(Console.ReadLine(), out long to ) )
                                                    {
                                                        System.Console.Write("Enter an amount you want to send: ");
                                                        if(decimal.TryParse(Console.ReadLine(), out decimal amount)) 
                                                        {
                                                            bank.Transfer(amount, tempAccountNumber, to);
                                                        }
                                                        else
                                                        {
                                                            System.Console.WriteLine("Input was wrong");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        System.Console.WriteLine("Input was wrong.");
                                                    }
                                                    break;
                                                }
                                                case 5:
                                                {
                                                    isOver = true;
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Input was wrong.");
                                        }
                            }
                                }
                                else
                                {
                                    System.Console.WriteLine("Name or Account Number is incorrect");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Input was incorrect.");
                            }
                            break;    
                        }
                        case 3:
                        {
                             bank.Database();
                            break;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Input was wrong try again!");
                }            
            }
        }
    }
}