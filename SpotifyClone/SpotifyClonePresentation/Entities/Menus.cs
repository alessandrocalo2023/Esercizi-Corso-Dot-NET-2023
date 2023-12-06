using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClonePresentation.Entities
{
    internal class Menus
    {
        string _choicelanguage;
        public void LanguageMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("** Welcome to your favorite Media Player **");
            Console.WriteLine("*******************************************");
            Console.WriteLine("please select you Language :");
            Console.WriteLine(" (I) Italian          ");
            Console.WriteLine(" (G) German         ");
            Console.WriteLine(" (F) French        ");
            Console.WriteLine(" (E) English        ");
            _choicelanguage = Console.ReadLine();
            switch (_choicelanguage)
            {
                case "I":
                    string dateInIT = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("it"));
                    Console.WriteLine(dateInIT);
                    break;
                case "G":
                    string dateInDE = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("de"));
                    Console.WriteLine(dateInDE);
                    break;
                case "F":
                    string dateInFR = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("fr-FR"));
                    Console.WriteLine(dateInFR);
                    break;
                case "E":
                    string dateInUSA = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("en-US"));
                    Console.WriteLine(dateInUSA);
                    break;
            }
        }

    }
}
