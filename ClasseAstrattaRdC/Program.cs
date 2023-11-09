using System;
using System.Security;

namespace ClasseAstrattaRdC
{
    internal class Astratta
    {
        static void Main(string[] args)
        {
            Comune comune = new Comune();
            Cittadino cittadino = new Cittadino("Mario", "Rossi", 61, 2, false);
            Studente studente = new Studente("Mario", "Rossi", 61, 2, false, 80);
            StudenteUNI studenteUni = new StudenteUNI("Mario", "Rossi", 61, 2, false, 25);
            Militare militare = new Militare("Mario", "Rossi", 61, 2, false, true);

            Console.WriteLine("Verifica cittadini aventi diritto al Reddito di Cittadinanza");

            Console.WriteLine("********* INSERIRE **********\n" + "Comune di residenza :");
            comune.NomeComune = Console.ReadLine();
            Console.WriteLine("Pil del Comune di residenza :");
            comune.Pil = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nome:");
            cittadino.Nome = Console.ReadLine();
            Console.WriteLine("Cognome:");
            cittadino.Cognome = Console.ReadLine();
            Console.WriteLine("età:");
            cittadino.Eta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("figli:");
            cittadino.Figli = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("studente - voto diploma:");
            studente.MediaMat = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("studente Universitario - media voti :");
            studenteUni.MediaUni = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("servizio militare assolto si/no");
            militare.StatoMilitare = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("debiti si/no");
            cittadino.Debiti = Convert.ToBoolean(Console.ReadLine());
            comune.Verifica();



        }
        // *******************************************************************
        abstract public class EntePubblico
        {
            internal string _nomeEnte;
        }
        public class Comune : EntePubblico
        {
            internal string _nomeComune;
            internal decimal _pil;
            static int parametroRDC;

            public string NomeComune
            {
                get { return _nomeComune; }
                set { _nomeComune = value; }
            }
            public decimal Pil
            {
                get { return _pil; }
                set
                {
                    if (value > 100)
                        parametroRDC = parametroRDC + 5;
                                   }
            }
            //Calcolo diritto al Reddito
            public static int Controllo(int val)
            { parametroRDC = parametroRDC + val;
                 return parametroRDC;
            }

            //Verifica del diritto al Reddito
            public void Verifica()
            { ;
                if (parametroRDC >= 25)
                {
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("** il cittadino ha diritto al Reddito di Cittadinanza **");
                    Console.WriteLine("********************************************************");
                }
                else
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine("** il cittadino non ha diritto al Reddito di Cittadinanza **");
                    Console.WriteLine("************************************************************");
                }
            }
        }
        // ******************************************************************
        abstract internal class Persona
        {
            protected string _nome;
            protected string _cognome;
            protected int _età;
            // ogni tipologia di cittadino implementa il metodo per il calcolo del diritto al Reddito
            public Persona(string Nome, string Cognome, int Età)
            {
                _nome = Nome;
                _cognome = Cognome;
                _età = Età;
            }

        }
        internal class Cittadino : Persona
        {

            //internal bool _statoMilitare;
            //internal decimal _mediaMAT;
            //internal decimal _mediaUni;
            internal decimal _figli;
            //internal decimal _pil;
            internal bool _debiti;
            
            //controllo raggiungimento valori attesi
              public int parametro;

            public Cittadino(string Nome, string Cognome, int Età, decimal Figli, bool debiti) : base(Nome, Cognome, Età)

            {
                _nome = Nome;
                _cognome = Cognome;
                _età = Età;
                _figli = Figli;
                _debiti = debiti;
            }
            //metodi GET e SET
            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public string Cognome
            {
                get { return _cognome; }
                set { _cognome = value; }
            }
            public int Eta
            {
                get { return _età; }
                set
                {
                    if (value >= 18 && value <= 25 || value > 60)
                        parametro = 5;
                    Comune.Controllo(parametro);
                        //_età = value;
                }
            }
            public bool Debiti
            {
                get { return _debiti; }
                set
                {
                    if (value == false)
                        parametro = 5;
                    Comune.Controllo(parametro); 
                }
            }
            public decimal Figli
            {
                get { return _figli; }
                set
                {
                    if (value >1)
                        parametro = 5;
                    Comune.Controllo(parametro); ;
                }
            }
        }
        internal class Militare : Cittadino
        {
            internal bool _statoMilitare;
            public Militare(string Nome, string Cognome, int Età, decimal Figli, bool debiti, bool statoMilitare) : base(Nome, Cognome, Età, Figli, debiti)
            {
                _statoMilitare = statoMilitare;
            }
            public bool StatoMilitare
            {
                get { return _statoMilitare; }
                set
                {
                    if (value == true)
                        parametro = 5;
                    Comune.Controllo(parametro); ;
                }
            }
        }
        internal class Studente : Cittadino
        {
            internal decimal _mediaMAT;
            public Studente(string Nome, string Cognome, int Età, decimal Figli, bool debiti, decimal MediaMAT) :
                                                                          base(Nome, Cognome, Età, Figli, debiti)
            {
                _mediaMAT = MediaMAT;
            }
            public decimal MediaMat
            {
                get { return _mediaMAT; }
                set
                {
                    if (value >= 90)
                        parametro = 5;
                    Comune.Controllo(parametro); ;
                }
            }

        }
        internal class StudenteUNI : Cittadino
        {
            internal decimal _mediaUni;

            public StudenteUNI(string Nome, string Cognome, int Età, decimal Figli, bool debiti, decimal MediaUni) :
                                                                           base(Nome, Cognome, Età, Figli, debiti)
            {
                _mediaUni = MediaUni;
            }
            public decimal MediaUni
            {
                get { return _mediaUni; }
                set
                {
                    if (value >= 28)

                        parametro = 5;
                    Comune.Controllo(parametro); ;
                }
            }
        }
    }
}




                //****************************************************************************************}