﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Account
    {
        private State _state;
        private string _owner;

        // Constructor
        public Account(string owner)
        {
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        // Properties
        public double Balance
        {
            get { return _state.Balance; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposit {0:C} ---", amount);
            Console.WriteLine(" Balance {0:C}", this.Balance);
            Console.WriteLine(" Status = {0} ---", this.State.GetType().Name);
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} ---", amount);
            Console.WriteLine(" Balance {0:C}", this.Balance);
            Console.WriteLine(" Status = {0} ---", this.State.GetType().Name);
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance {0:C}", this.Balance);
            Console.WriteLine(" Status = {0} ---", this.State.GetType().Name);
        }
    }
}