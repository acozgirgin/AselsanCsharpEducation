using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Encapsulation
{
    public class BankAccountClient
    {
        public BankAccountClient()
        {
            
        }

    }



    public class BankAccount(string accountNumber) // --> Primary constructor tanımladık
    {

        private string _accountNumber = accountNumber;
        private decimal _balance;

        //public BankAccount(string accountNumber)    
        //{
        //    _accountNumber = accountNumber;
        //}
        public void SetBalance(decimal amount)
        {
            if(amount<5000 || amount>10000)
            {
                throw new Exception("ERROR: Balance set is not valid.");
            }

            _balance = amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount < 0)
            {
                throw new Exception("ERROR: Negative amount input is not valid.");

            }

            if(amount > _balance)
            {
                throw new Exception("ERROR: Balance is not valid for withdraw operation.");

            }

            _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new Exception("ERROR: Negative amount input is not valid !");
            }

            _balance += amount;
        }



    }


}
