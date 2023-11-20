using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AdminFunctions.Classes;

namespace AdminFunctions
{
    public class municipality : euCitizenPublicServ
    {
        string _name;
        euID _euid;
        public string Name { get { return _name; } set { _name = value; } }
        euCitizen _eucitizen;
        province _province;
        int _choiceService;


        public void Municipality(string Name,province Province,euID ID) 
        {
            _name = Name;
            _province = Province;
            //passo un oggetto euID cosìda poter richiamare la funzione di creazione dell'ID 
            _euid = ID;
     
           
      
        }
       //Acquisizione dati del cittadino e gestione servizi
        public void ServicesCitizen(euCitizen euCitizen)
        {
            _eucitizen = euCitizen;
            Console.WriteLine($"Wellcome : Citizen Municipaly Services of" + " " + _eucitizen._muniname);
            Console.WriteLine("Choose your service:" );
            Console.WriteLine("1)ID release");
            Console.WriteLine("2)SSN assistance");
            Console.WriteLine("2)LAW assistance");
            Console.WriteLine("2)Welfare services");
            _choiceService = Convert.ToInt16(Console.ReadLine());
       }
        //interfaccia gestione cittadino
        public void AddCitizen(euCitizen euCitizen)
                        { _eucitizen = euCitizen; }
        public void RemoveCitizen(euCitizen Citizen)
        { _eucitizen = null; }

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
