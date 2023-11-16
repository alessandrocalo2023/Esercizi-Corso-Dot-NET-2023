using AdminFunctions.Classes;
using AdminFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    abstract class euCitizenPublicServ 
    {
        //+ Wellfare Services(): abstract
        //+ HNS(EU ID) : overload
        //+ Educational System(EU ID) :overload
       
        //overload dei metodi seguenti
        public void SSNAssistance(euID EuCitizenID) { }
        public void LAWAssistance() { }
        public void EDUSystem(euID EuCitizenID) { }
        abstract public void WelfarServices();



    }
}
