using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural =  StateDesignPatternTester.StructuralCode;

namespace StateDesignPatternTester
{
    /// <summary>
    /// Mainapp startup class for
    /// State Design Pattern
    /// </summary>
    class Program
    {
        // State

        // Definition
        // Allow an object to alter its behavior when its internal state changes.
        // The object will appear to change its class. 

        // Participants
        // The classes and objects participating in this pattern are:
        //  - Context (Account)
        //       - defines the interface of interest to clients
        //       - maintains an instance of a ConcreteState subclass that defines the current state.
        //  - State (State)
        //       - defines an interface for encapsulating the behavior associated with a particular state of the Context.
        //  - Concrete State (RedState, SilverState, GoldState)
        //       - each subclass implements a behavior associated with a state of Context

        /// <summary>
        /// Entry point into console application
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the State pattern which allows an object to behave differently
            // depending on its internal state. The difference in behavior is delegated to objects that represent this state. 
            
            // Setup context in a state
            Structural.Context c = new Structural.Context(new Structural.ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}
