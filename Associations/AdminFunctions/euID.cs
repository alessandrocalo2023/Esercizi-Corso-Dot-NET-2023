using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    public class euID
    {
        string _id;
        euCitizen _euCitizenID;

      //in euCitizenPublicServ
        public euID(string ID)
                              { _id = ID; }
        public void EuIDCreate(euCitizen EuCitizenID) {
            _euCitizenID = EuCitizenID;
            //costruire un metodo che crea l'ID combinando nome e data di nascita del Cittadino
            _id = _euCitizenID.Name + _euCitizenID._birthday;
            Console.WriteLine("ID code is:" + _id);

     
        }
    }
}
