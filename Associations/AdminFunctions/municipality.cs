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
        
        public string Name { get { return _name; } set { _name = value; } }
        euCitizen _euCitizen;
        euID _euId;
        province _province;
        int _choiceService;


        public municipality(string Name,province Province) 
        {
            _name = Name;
            _province = Province;
            //passo un oggetto euID cosìda poter richiamare la funzione di creazione dell'ID 
           
     
           
      
        }
       //Acquisizione dati del cittadino e gestione servizi
        public void ServicesCitizen(euCitizen euCitizen)
        {
            _euCitizen = euCitizen;
            _euId = _euCitizen._id;
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine($"Wellcome : Citizen Municipaly Services of" + " " + _euCitizen._muniname);
                Console.WriteLine("Choose your service:");
                Console.WriteLine("1)ID release");
                Console.WriteLine("2)SSN assistance - not available");
                Console.WriteLine("3)LAW assistance  - not available");
                Console.WriteLine("4)Welfare services  - not available");
                _choiceService = Convert.ToInt16(Console.ReadLine());

                switch (_choiceService)
                {
                    case 1:
                        {
                            //create and print new ID
                          _euId.EuIDCreate(_euCitizen);
                        }
                        break;
                }
            }
        }
        //interfaccia gestione cittadino
        public void AddCitizen(euCitizen euCitizen)
                        { _euCitizen = euCitizen; }
        public void RemoveCitizen(euCitizen Citizen)
        { _euCitizen = null; }

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
