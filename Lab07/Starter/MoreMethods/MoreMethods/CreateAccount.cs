﻿using System;

namespace MoreMethodsNameSpace
{
    class CreateAccount
    {

        //--.
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);

        }


        //--.
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //--.
            //Console.Write("Enter the account number    : ");
            //long number = long.Parse(Console.ReadLine());
            //long number = BankAccount.NextNumber();


            //--.
            Console.Write("Enter the account balance!  : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //--.
            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;
            created.Populate(balance);

            return created;
        }

        //--.
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Ballance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

        //--.
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");

            decimal amount = (decimal)InputModule.inputPositiveValue();



            acc.Deposit(amount);
        }

        //--.
        public static void TestWithdraw(BankAccount acc)
        {
            //--.
            Console.Write("Enter amount to withdraw: ");
            //--.
            decimal amount = decimal.Parse(Console.ReadLine());
            //--.
            if( !acc.Withdraw(amount) )
            {
                Console.WriteLine("Insufficient funds.");
            }
        }


    }
}
