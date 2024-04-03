﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Phase3
{
    class Account
    {

        public double MIN_BALANCE = 50;
        public double CHECKING_MAX = 1000;
        public double SAVING_MAX = 500;
        public string ownerName;
        public string ownerAddress;
        public string branchCity;
        public string accountNumber;
        public string accountType;
        public string accountDate;
        public int ownerYOB;
        public double balance;

        public Account()
        {
            accountType = "Checking";
            balance = 100;
        }
        public Account(string ownerName, int ownerYOB, string accountNum, string accountType, double balance)
        {
            this.ownerName = ownerName;
            this.ownerYOB = ownerYOB;
            accountNumber = accountNum;
            this.accountType = accountType;
            this.balance = balance;
        }
        public string GetName()
        {
            return ownerName;
        }
        public string GetAddress()
        {
            return ownerAddress;
        }
        public int GetAge()
        {
            return (2022 - ownerYOB);
        }
        public string GetCity()
        {
            return branchCity;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public string GetAccountType()
        {
            return accountType;
        }
        public string GetAccountDate()
        {
            return accountDate;
        }
        public void SetName(string name)
        {
            ownerName = name;
        }
        public void SetAddress(string address)
        {
            ownerAddress = address;
        }
        public void SetYOB(int year)
        {
            ownerYOB = year;
        }
        public void SetCity(string city)
        {
            branchCity = city;
        }
        public void Deposit(double amnt)
        {       
                balance += amnt;     
        }
        public double Withdraw(double amnt)
        {
            double exceededAmnt;
            double amntWithdrawn = 0;
            if (amnt > 0)
            {
                if (accountType == "Checking")
                {
                    if (amnt > CHECKING_MAX || (balance - amnt) <MIN_BALANCE)
                    {
                        amntWithdrawn = 0;
                    }
                    else
                    {
                        balance -= amnt;
                        amntWithdrawn = amnt;


                    }
                    
                }
                else if (accountType == "Saving")
                {
                    if (amnt > SAVING_MAX || (balance - amnt) >= MIN_BALANCE)
                    {
                        amntWithdrawn = 0;
                    }
                    else
                    {
                        balance -= amnt;
                        amntWithdrawn = amnt;


                    }
                }
            }
            else
            {
                amntWithdrawn = 0;
            }
            return amntWithdrawn;
        }
        public void SetAccountNumber(string accntNum)
        {
            accountNumber = accntNum;
        }
        public void SetAccountType(string accntType)
        {
            accountType = accntType;
        }
        public void SetAccountDate(string accntDate)
        {
            accountDate = accntDate;
        }
        public double Transfer(Account accnt, double amnt)
        {
            double amntTransfered = 0;
            double exceededAmnt;
            if (accountType == "Checking")
            {
            
                if (amnt > CHECKING_MAX|| (balance-amnt) <MIN_BALANCE)
                { 
                    amntTransfered = 0;
                }

                else 
                {
                    balance -= amnt;
                    accnt.balance += amnt;
                    amntTransfered = amnt;

                }
                
            }
            else if (accountType == "Saving")
            {
                if (amnt > SAVING_MAX|| (balance - amnt)< MIN_BALANCE)
                {
                    amntTransfered = 0;
                }
                else
                {
                    balance -= amnt;
                    accnt.balance += amnt;
                    amntTransfered = amnt;


                }
                
            }

            return amntTransfered;
        }
        public override string ToString()
        {
            return $"Name: {ownerName} \n" + "Age: " + GetAge().ToString() + $"\nAccount Type: {accountType}\nAccount Number: {accountNumber}\nBalance: {balance:C2}";
        }

    }
}
