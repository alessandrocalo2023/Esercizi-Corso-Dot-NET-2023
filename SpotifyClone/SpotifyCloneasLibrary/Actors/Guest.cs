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
        public Guest() { }
        public void GuestMenu(Guest GuestLogin,Start Start)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Guest - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("*******    Welcome    *******");
            Console.WriteLine("*****************************");
            Console.WriteLine("*** choose you favorite : ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Play - Song ");
            Console.WriteLine("2) PlayList - not available for this accout");
            Console.WriteLine("3) Album - not available for this account");
            Console.WriteLine("4) Play - Radio");
            Console.WriteLine("0) Main menu");
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
                case 0:
                    break;
            }
            if (_choiceMenu == 0 ||_choiceMenu > 5) Start.Menu();
        }
        }
    }

