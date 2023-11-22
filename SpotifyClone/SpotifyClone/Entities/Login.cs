using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyClone;

namespace SpotifyClone.Entities
{
    public class Login
    {
        private string _username;
        private string _password;
        private bool _checkLogin;
        private int _checkAccess;
        User _UserLogin;
        Guest _UserGuest;
        Start _Start;
        public void LoginCheck(User User, Guest Guest,Start Start)
        {
            _UserLogin = User;
            _UserGuest = Guest;
            _Start = Start;

            Console.WriteLine("*******************************************");
            Console.WriteLine("** Welcome to your favorite Media Player **");
            Console.WriteLine("*******************************************");
 restart:           
             Console.WriteLine("please select your access type");
                Console.WriteLine(" ");
                Console.WriteLine("1)Account");
                Console.WriteLine("2)Guest");
                Console.WriteLine("0)Exit ");
                _checkAccess = Convert.ToInt16(Console.ReadLine());
            while (!_checkLogin)
            {
                switch (_checkAccess)
                {
                    case 1:
                        {
                            Console.WriteLine("please insert");
                            Console.Write("username:");
                            _username = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("password:");
                            _password = Console.ReadLine();
                            Console.WriteLine();
                            if (_username == _UserLogin._username &&
                                _password == _UserLogin._password)
                            {
                                User.UserMenu(_Start);
                                _checkLogin = true;
                            }
                            else
                            { Console.WriteLine("*********** Access Denied*********");
                                goto restart;
                            }
                        }
                        break;
                    case 2:
                        Guest.GuestMenu(_Start);
                        break;
                    case 0:
                        Task.Delay(10000);
                        Start.Menu();
                        break;
                }
                Console.WriteLine("Warning ! - wrong input");
                Console.WriteLine("Please re-type");
            }

        }

    }
}
  

