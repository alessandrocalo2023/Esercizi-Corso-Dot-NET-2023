using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SpotifyCloneDatasource;
using SpotifyCloneDatasource.Users;
using SpotifyClonePresentation;
using SpotifyClonePresentation.Entities;




namespace SpotifyClonePresentation.Entities
{
    public class Login
    {
        public string _username;
        public string _password;
        public bool _checkLogin;
        public int _checkAccess;
        public string _choicelanguage;
        public string _cultureinfo;
        internal string dateInIT;
        internal string dateInDE;
        internal string dateInFR;
        internal string dateInUSA;
         
       
       User _UserLogin;
       UserGuest _UserGuest;
       UserPremium _UserPremium=new UserPremium();
       UserGold _UserGold = new UserGold();
       Start _Start;
       
        
            public void LoginCheck(User User, Start Start)
        {
             _UserLogin = User;
            //_UserGuest = Guest;
            _Start = Start;
            //_Song = Song;
                  
       reLogin: Console.WriteLine("please select your access type");
            Console.WriteLine(" ");
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
                        Console.WriteLine("-    Premium    -");
                        Console.WriteLine("- please insert -");
                        Console.WriteLine("-----------------");
                        Console.Write("username:");
                        _username = Console.ReadLine();
                        Console.Write("password:");
                        _password = Console.ReadLine();
                        Console.WriteLine();
                                            
                        if (_username == _UserPremium.Username && _password == _UserPremium.Password)
                        {
                         
                            User.UserMenu(_UserLogin, _UserPremium.ListenTime);
                            _checkLogin = true;
                        }
                        else
                          Console.WriteLine("*********** Access Denied*********");
                        goto reLogin;
                                                                 
                    case 2:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("-      Gold     -");
                        Console.WriteLine("- please insert -");
                        Console.WriteLine("-----------------");
                        Console.Write("username:");
                        _username = Console.ReadLine();
                        Console.Write("password:");
                        _password = Console.ReadLine();
                        Console.WriteLine();

                      if (_username == _UserGold.Username && _password == _UserGold.Password)
                            {
                              
                            User.UserMenu(_UserLogin, _UserGold.ListenTime);
                                _checkLogin = true;
                            }
                            else
                             Console.WriteLine("*********** Access Denied*********");
                                goto reLogin;
                    
                     case 3:
                        UserGuest UserGuest = new UserGuest();
                        //_UserGuest._ListenTime = 360000;
                        UserGuest.GuestMenu();
                                break;
                    case 0:
                                Task.Delay(10000);
                                Start.MenuSource();
                                break;
                            }
                            Console.WriteLine("Warning ! - wrong input");
                            Console.WriteLine("Please re-type");
                        }

                }

            }
        } 

