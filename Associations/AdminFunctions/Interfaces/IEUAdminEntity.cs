using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions.Interfaces
{
    internal interface IEUAdminEntity: IAdminEntity
    {//+ Border ReDefinition(Parliament)
     //+ Wellfare Services(): 
        public string BorderReDefinition();
        public string WelfarServices();
    }
}
