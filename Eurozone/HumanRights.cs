using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Eurozone.Program;

namespace Eurozone
{
    public class HumanRights
    {
        public static void CorteEuropeaRights(State TestState)
        {
            if (TestState.humanrights == false)
            {
                Console.WriteLine("Stato :" + TestState.name);
                Console.WriteLine("applica la pena di morte");
            }
            else
            {
                Console.WriteLine("Stato :" + TestState.name);
                Console.WriteLine("Non applica la pena di morte");
            }
        }
    }
}
