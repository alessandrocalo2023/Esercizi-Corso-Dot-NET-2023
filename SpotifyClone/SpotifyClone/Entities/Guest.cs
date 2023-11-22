using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyClone;

namespace SpotifyClone.Entities
{
    public class Guest
    {
        int _choiceMenu;
        internal string GuestMenuTop = "1) Song - 2) PlayList - 3) Album - 4) Radio - 5)Search - 5) Main Menu";

        public Guest() { }
        public void GuestMenu(Start Start)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Guest - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("*** choose you favorite : ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Song :");
            Console.WriteLine("2) PlayList - not available for this accout");
            Console.WriteLine("3) Album - not available for this account");
            Console.WriteLine("4) Radio");
            Console.WriteLine("5 return to main menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    {

                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            if (_choiceMenu == 0 ||_choiceMenu > 5) Start.Menu();
        }
        }
    }

