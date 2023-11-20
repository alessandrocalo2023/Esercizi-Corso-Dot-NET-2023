using System;
using AdminFunctions.Interfaces;
using AdminFunctions.Classes;
namespace AdminFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            euCitizen MarioRossi = new euCitizen("Mario Rossi", "1 Aprile 1990", "Viale Libertà 101", "Merano", "Merano", "");
            //province Milano = new();
            
            province Brescia = new province ("Brescia");
            province Bergamo = new province ("Bergamo");
            province Milano = new province("Milano");

            
            region Lombardia =new("Lombardia");
            euID MR1041990 = new();
            municipality Merano = new();

            choice choice = new();
            //choice.ChoiceService(MarioRossi, Merano);
            //Merano.ServicesCitizen(MarioRossi);
            census Censimento=new census();

            Censimento.Census(Lombardia, Brescia);
            
            Censimento.Census(Lombardia, Bergamo);
            Censimento.CensusPrint(Lombardia) ;
            //Censimento.Census(Lombardia, Milano);
        }
        public class choice {
            
                int _choiceService;
                euCitizen _euCitizenChoiceService;
                municipality _municipalityChoiseService;
                
public void ChoiceService(euCitizen euCitizenChoiceService, 
    municipality MunicipalityChoiceService)
            {
                _euCitizenChoiceService = euCitizenChoiceService;
                _municipalityChoiseService = MunicipalityChoiceService;
                Console.WriteLine("Choose your service:");
                Console.WriteLine("1)Services for Citizen");
                Console.WriteLine("2)Services for Public Administrations");
                _choiceService = Convert.ToInt16(Console.ReadLine());

                if (_choiceService == 1) { _municipalityChoiseService.ServicesCitizen(euCitizenChoiceService); }
            }
            }
        }
    }

