﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// A 'ConcreteState' class
    /// Silver indicates a non-interest bearing state
    /// </summary>
    class SilverState : State
    {
        // Overloaded constructors

        public SilverState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public SilverState(double Balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }
        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
    }
}
