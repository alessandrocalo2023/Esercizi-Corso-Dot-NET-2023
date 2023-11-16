using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions.Interfaces
{
    internal interface IAdminEntity
    {//+HNS()
     //+LAW system()
     //+Educational System()
        public void SSNAssistance(euID EuCitizenID);
        public string LAWAssistance();
        public void EDUSystem(euID EuCitizenID);
    }
}
