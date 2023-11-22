using SpotifyClone.Entities;
using System;
using SpotifyClone.Interfaces;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;

namespace SpotifyClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool execute;
            // while (execute)
            // {
            User User = new User();
            Guest Guest = new Guest();
            Login Login = new Login();
            Start Start = new Start();


            Song TestSong = new Song("Coming back to life",260);
            Mediacomponent Mediacomponent = new Mediacomponent();

        //   Start.Menu();
         //    Login.LoginCheck(User, Guest,Start);
           Mediacomponent.Play(TestSong);
            //}
            


            //Mediacomponent.Play(TestSong);

        }

       
    }

    public class Start
    {
        int _choice;
        public Start() { }
        public void Menu()
        {
            Console.WriteLine("**********  starting.......*******");
            Task.Delay(1000000);
            Console.Write("\r)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("** Welcome to your favorite Media Player **");
            Console.WriteLine("*******************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Please select your media source");
            Console.WriteLine(" ");
            Console.WriteLine("1) Web");
            Console.WriteLine("2) SD memory");
            Console.WriteLine("3) Radio");
            Console.WriteLine("0) Exit");
            _choice = Convert.ToInt16(Console.ReadLine());
            //while (_choice != 0 && _choice > 4) ;
            switch (_choice)
            {
                case 1:
                    break;
                case 2:
                   break;
                case 3:
                   break;
                case 0:
                    Console.WriteLine("**********************************");
                    Console.WriteLine("*** thank you  *****   Bye bye ***");
                    Console.WriteLine("**********************************");
                    Task.Delay(10000);
                    Environment.Exit(1);
                    break;
                   
                    }
            }
    }
}
    

