using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace console_bank {
    class Account {
        public string accountType;
        public long accountNumber;
        public double balance;
        public string owner;
        public DateTime dateCreated;

        public Account(string accountType, long accountNumber, double balance, string owner, DateTime dateCreated)
        {
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.owner = owner;
            this.dateCreated = 
        }

        public double getBalance()
        {
            return this.balance;
        }

        public double depositeFunds(double amount)
        {
            this.balance += amount;
            return this.balance;
        } 
        public double withdrawFunds(double amount)
        {
            if (balance-amount >0)
            {
                this.balance -= amount;
            }
            
            return this.balance;
        }

        public double transferFunds(long accountNo, double amount) {
            //this.balance += amount;
            return this.balance;
        }

        }

    }
