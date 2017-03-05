using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        public abstract void Calcola(Dichiarazione context);
        public abstract void Stampa(Dichiarazione context);
        public abstract void Modifica(Dichiarazione context);
    }
}
