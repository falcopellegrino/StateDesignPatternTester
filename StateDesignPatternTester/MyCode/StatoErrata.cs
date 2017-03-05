using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTester.MyCode
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class StatoErrata : State
    {
        public override void Calcola(Dichiarazione context)
        {
            context.State = new StatoCompleta(); 
        }

        public override void Stampa(Dichiarazione context)
        {
            context.State = new StatoStampata();
        }

        public override void Modifica(Dichiarazione context)
        {
            context.State = new StatoErrata();
        }
    }
}
