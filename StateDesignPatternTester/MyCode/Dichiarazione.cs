using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Dichiarazione
    {
        private State _state;

        public Dichiarazione(State state)
        {
            this._state = state;
        }

        // Gets or sets the state
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Calcola()
        {
            _state.Calcola(this);
        }
        public void Stampa()
        {
            _state.Stampa(this);
        }
        public void Modifica()
        {
            _state.Modifica(this);
        }
    }
}
