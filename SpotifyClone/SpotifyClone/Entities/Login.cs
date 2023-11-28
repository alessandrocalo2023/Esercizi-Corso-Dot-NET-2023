using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyClone;


namespace SpotifyClone.Entities
{
    public class Login
    {
        public string _username;
        public string _password;
        public bool _checkLogin;
        public int _checkAccess;
        public string _choicelanguage;
        public string _cultureinfo;
        string dateInIT;
        string dateInDE;
        string dateInFR;
        string dateInUSA;
        //save the date format for all program' parts
        string _dateFormatnow;
        int _ListenTime;
        //FreeUser Freeuser=new FreeUser();
        //GoldUser GoldUser=new GoldUser();
        //PremiumUser PremiumUser=new PremiumUser();  
        User _UserLogin;
        Guest _UserGuest;
        Start _Start;
        Song _Song;
        public void LoginCheck(User User, Guest Guest, Start Start, Song Song)
        {
            _UserLogin = User;
            _UserGuest = Guest;
            _Start = Start;
            _Song = Song;

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
            { case "I":
                    string dateInIT = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("it"));
                    Console.WriteLine(dateInIT);
                    //_dateFormatnow = dateInIT;
                    _cultureinfo = "it";
                    break;
                case "G":
                    string dateInDE = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("de"));
                    Console.WriteLine(dateInDE);
                    //_dateFormatnow = dateInDE;
                    _cultureinfo = "de";
                    break;
                case "F":
                    string dateInFR = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("fr-FR"));
                    Console.WriteLine(dateInFR);
                    //_dateFormatnow = dateInFR;
                    _cultureinfo = "fr-FR";
                    break;
                case "E":
                    string dateInUSA = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("en-US"));
                    Console.WriteLine(dateInUSA);
                    //_dateFormatnow = dateInUSA;
                    _cultureinfo = "en-US";
                    break;
            }

   restart: Console.WriteLine("please select your access type");
            Console.WriteLine(" ");
            //Console.WriteLine("1)Account");
            Console.WriteLine("   -----------------");
            Console.WriteLine("1) -   Premium     -");
            Console.WriteLine("   -----------------");
            Console.WriteLine("2) -   Gold        -");
            Console.WriteLine("   -----------------");
            Console.WriteLine("3) -   Guest(free) -");
            Console.WriteLine("   -----------------");
            Console.WriteLine("0) -   Exit        -");
            Console.WriteLine("   -----------------");

            _checkAccess = Convert.ToInt16(Console.ReadLine());
            while (!_checkLogin)
            {
                switch (_checkAccess)
                {
                    case 1:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("- please insert -");
                        Console.WriteLine(" (admin),(admin) ");
                        Console.WriteLine("-----------------");
                        Console.Write("username:");
                        _username = Console.ReadLine();
                        Console.Write("password:");
                        _password = Console.ReadLine();
                        Console.WriteLine();
                        if (_username == _UserLogin._username && _password == _UserLogin._password)
                        {
                            _UserLogin._ListenTime = 3600000;
                            User.UserMenu(_UserLogin, _Start, _Song,_cultureinfo);
                            _checkLogin = true;
                        }
                        else
                        
                            Console.WriteLine("*********** Access Denied*********");
                        goto restart;
                        
                                           
                    case 2:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("- please insert -");
                        Console.WriteLine(" (admin),(admin) ");
                        Console.WriteLine("-----------------");
                        Console.Write("username:");
                        _username = Console.ReadLine();
                        Console.Write("password:");
                        _password = Console.ReadLine();
                        Console.WriteLine();


                        if (_username == _UserLogin._username && _password == _UserLogin._password)
                            {
                            _UserLogin._ListenTime = 360000000;
                                User.UserMenu(_UserLogin, _Start, _Song,_cultureinfo);
                                _checkLogin = true;
                            }
                            else
                            
                                Console.WriteLine("*********** Access Denied*********");
                                goto restart;
                            
                       
                        
                    case 3:
                        _UserGuest._ListenTime = 360000;
                        Guest.GuestMenu(_UserGuest, _Start, _ListenTime, _cultureinfo);
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

