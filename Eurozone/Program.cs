using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Eurozone
{
    public class Program
    {
        static void Main(string[] args)
        {
            //no ONU no UE no Eurozona si Pena di morte
            State Texas = new State("Texas", "10M", true, false, false, false);
            //no ONU no UE no Eurozona
            State CoreaNord = new State("North Corea", "6M", false, false, false, false);
            //ONU no UE no Eurozona
            State Giappone = new State("Japane", "11M", true, false, false, true);
            //ONU , UE no Eurozona
            State Svizzera = new EUState("Swiss", "5M", true, true, false, true);
            //ONU , UE , Eurozona
            State Italia = new EUROState("Italia", "50M", true, true, true, true);

            //State.EurocentralBank(Texas);
            //State.EurocentralBank(CoreaNord);
            //State.EurocentralBank(Giappone);
            //State.EurocentralBank(Svizzera);
            State.EurocentralBank(Italia);
            Console.WriteLine("vuoi proseguire ?");
            Console.WriteLine("premi il tasto invio");
            Console.Read();
            //State.CorteEuropeaRights(Texas);
            //State.CorteEuropeaRights(CoreaNord);
            //State.CorteEuropeaRights(Giappone);
            //State.CorteEuropeaRights(Svizzera);
            //State.CorteEuropeaRights(Italia);
 //test da libreria
            HumanRights.CorteEuropeaRights(Texas);
            HumanRights.CorteEuropeaRights(Italia);


        }
        //interfaccia definizione caratteri base di definizione di uno stato
        interface IONU
        {
            public void Defence();
            public void PopulationControl(string P);
        }
        interface IEU
        {
            public void EUConstitution();
            public void EUTribunal();
        }
        interface IEURO
        {
            public void EuroMoney();
        }

        abstract public class country
        {//dettagliare i parametri base dello stato
            protected string population;
            public string name;
            public void Country(string Population, string Name) { }
            //public string Population { get { return population; } set { population = value; } }
            //public string Name { get { return name; } set { name= value; } }

        }
        public class State : country, IONU
        {
            // eredita da Paese e implementa l'interfaccia IONU
            internal bool humanrights;
            internal bool onu;
            //costruttore classe principale Stato 
            public State(string Name, string Population, bool ONU, bool EU, bool EURO, bool HumanRights)
            {
                name = Name;
                population = Population;
                onu = ONU;
                humanrights = HumanRights;
            }
            public string Population { get { return population; } set { population = value; } }
            public string Name { get { return name; } set { name = value; } }
            public bool Onu { get { return onu; } set { onu = value; } }
            public bool Humanrights { get { return humanrights; } set { humanrights = value; } }
            public void PrintName(string Name)
            {
                Console.WriteLine(" Stato:" + Name);
            }
            public void Defence()
            { Console.WriteLine("possiede un esercito"); }
            public void PopulationControl(string People)
            {
                Console.Write("possiede un popolazione censita di: " + People + "\n");
            }
            public static void EurocentralBank(State TestState)
            {
                if (TestState.onu == true)
                {
                    if (TestState is EUState)
                    {
                        EUState eutest = (EUState)TestState;
                        if (eutest.eu == true)
                        {
                            if (TestState is EUROState)
                            {
                                EUROState eurotest = (EUROState)TestState;
                                if (eurotest.ieuro == true)
                                {
                                    Console.WriteLine("Membro dell'EuroZona");
                                    eurotest.PrintName(eurotest.name);
                                    eurotest.Defence();
                                    eurotest.PopulationControl(eurotest.population);
                                    eurotest.EUConstitution();
                                    eurotest.EUTribunal();
                                    eurotest.EuroMoney();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Membro della Comunità Europea");
                                eutest.PrintName(eutest.name);
                                eutest.Defence();
                                eutest.PopulationControl(eutest.population);
                                eutest.EUConstitution();
                                eutest.EUTribunal();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Membro dell'ONU");
                        TestState.PrintName(TestState.name);
                        TestState.Defence();
                        TestState.PopulationControl(TestState.population);
                    }
                }

            }
            //Verifica Diritti Umani
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
        internal class EUState : State, IONU, IEU
            {
                internal bool eu;
                public EUState(string Name, string Population, bool ONU, bool EU, bool EURO, bool HumanRights): base(Name, Population, ONU, EU, EURO, HumanRights)
                {
                    eu = EU;
                }
                public bool Eu { get { return eu; } set { eu = value; } }
                public void EUConstitution()
                { Console.WriteLine("adotta la Costituzione Europea"); }
                public void EUTribunal()
                { Console.WriteLine("si avvale del Tribunale per i Diritti Umani"); }
            }
         internal class EUROState : EUState, IONU, IEU, IEURO
            {
                internal bool ieuro;
                double spread = 0.90;
                public EUROState(string Name, string Population, bool ONU, bool EU, bool EURO, bool HumanRights) : base(Name, Population, ONU, EU, EURO, HumanRights)
                {
                    ieuro = EURO;

                }
                public bool Ieuro { get { return ieuro; } set { ieuro = value; } }
                public void EuroMoney()
                {

                    Console.WriteLine("adotta l'Euro come valuta ufficiale");
                    Console.WriteLine("lo spread corrisponde allo:" + spread + "%");
                }
            }
        }
    }










