using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    internal class euID
    {
        string _id;
        euCitizen _euCitizenforID;

      //in euCitizenPublicServ
        public void EuID(string ID)
        { _id = ID; }
        public string EuIDCreate(euCitizen EuCitizenID) {
            _euCitizenforID = EuCitizenID;
            //costruire un metodo che crea l'ID combinando nome e data di nascita del Cittadino
            _id = _euCitizenforID.Name;
            return _id;
        }
    }
}
