using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdminFunctions
{
    internal class municipality : euCitizenPublicServ
    {
        string _name;
        euID _euid;
        public string Name { get { return _name; } set { _name = value; } }
        citizen _citizen;
        province _province;

        public void Municipality(string Name,province Province,euID ID) 
        {
            _name = Name;
            _province = Province;
            //passo un oggetto euID cosìda poter richiamare la funzione di creazione dell'ID 
            _euid = ID;
      
        }
      
        
        public void AddCitizen(citizen Citizen)
                        { _citizen = Citizen; }
        public void RemoveCitizen(citizen Citizen)
        { _citizen = null; }

        public void ChangeProvince(province Province)
        { _province.removeMunicipality(this);
            _province = Province;
        }
        //interfaccia servizi cittadino
        public void SSNAssistance(euID IDCitizen,euCitizen EuCitizen) { }
        public void LAWAssistance(string LAWAssistant) { }
        public void EDUSystem(euID IDCitizen, euCitizen EuCitizen) { }
        public override void WelfarServices() { }


    }


}
