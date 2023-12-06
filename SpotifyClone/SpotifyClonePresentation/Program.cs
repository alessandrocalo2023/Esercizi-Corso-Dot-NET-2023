
using System;
using SpotifyCloneDatasource;
using SpotifyCloneDatasource.Users;
using SpotifyClonePresentation.Entities;
using SpotifyCloneService.Interfaces;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.CompilerServices;


namespace SpotifyClonePresentation
{
    internal class Program
    {
        int _MediaSupport;
        static void Main(string[] args)
        {




            User User1 = new User("Leo", "Nardi", "20 Maggio 2000", false);
            User UserAdmin = new User("Bud", "Spencer", "31 ottobre 1929", true);
            UserGuest Guest = new UserGuest();
            Login Login1 = new Login();
            Start Start = new Start();
            Radio Radio = new Radio();
            Song Song1 = new Song("Pink Floyd", "Pink Floyd", "Coming Back to life", 380, "Rock", "1993", 1, false);
            Song Song2 = new Song("AC/DC", "AC/DC", "Highway to Hell", 219, "Rock", "1979", 0, false);
            Artist Artist = new Artist("Brian Adams", "born in Chicago", "20th April 1960", "Rock", 0);
            Artist Artist1 = new Artist("Freddy Mercury", "born in Stone Town", " 5th September 1946", "Rock", 1);
            // Equalizer equ = new Equalizer();
            // Mediacomponent Mediacomponent = new Mediacomponent();

            //Start.Menu();
            // Song could not be share, while is available a DB
            Login1.LoginCheck(UserAdmin,Start);
        }
    }
    public class Start
    {
        int _choice;
        int _MediaSupport;
        int _MediaChoice;
        public Start() { }
        //choose between available media sources
        public void MenuSources()
        {
            Console.WriteLine("**********  starting.......*******");
            Task.Delay(1000000);
            Console.Write("\r)");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("** Welcome to your favorite        ** ");
            Console.WriteLine("**         Media Player            **");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("-- Please select your media source --");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("-- 1) Web");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("-- 2) SD memory");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("-- 0) Exit");
            Console.WriteLine("------------------------------------- ");
            _choice = Convert.ToInt16(Console.ReadLine());
            //while (_choice != 0 && _choice > 4) ;
            switch (_choice)
            {
                case 1:
                    _MediaSupport = 1;
                    //Login.LoginCheck(UserAdmin, Guest, Start, Song1);
                    break;
                case 2:
                    _MediaSupport = 2;
                    break;
                case 0:
                    {
                        Console.WriteLine("------------------------------------- ");
                        Console.WriteLine("--- thank you  ------   Bye bye   ---");
                        Console.WriteLine("------------------------------------- ");
                        Task.Delay(100000);
                        Environment.Exit(1);
                        break;

                    }
            }
        }
        //choose between Songs or Movie to play
        public void MenuObject()
        {

            Task.Delay(1000000);
            Console.Write("\r)");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("- Please select your favorite media -");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("1) Songs ");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("2) Videos");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine("0) Exit");
            Console.WriteLine("------------------------------------- ");
            Console.WriteLine(" ");
            _choice = Convert.ToInt16(Console.ReadLine());
            //while (_choice != 0 && _choice > 4) ;
            switch (_choice)
            {
                case 1:
                    _MediaChoice = 1;
                    //Login.LoginCheck(UserAdmin, Guest, Start, Song1);
                    break;
                case 2:
                    _MediaChoice = 2;
                    break;
                case 0:
                    {
                        Console.WriteLine("------------------------------------- ");
                        Console.WriteLine("--- thank you  ------   Bye bye   ---");
                        Console.WriteLine("------------------------------------- ");
                        Task.Delay(100000);
                        Environment.Exit(1);
                        break;

                    }
            }

        }
    }
}
    

