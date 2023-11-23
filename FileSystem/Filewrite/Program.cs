using System;
using System.Collections.Generic;
using Filewrite.Entities;
namespace Filewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Tiziana\Desktop";
            User user = new User();
            Account account = new Account();

            Menu menu = new Menu();

            menu.MenuStart(user, account, path);
        }
        public class Menu
        {

            int _choice;
            string _path;
            Account _account;
            User _user;
            public Menu() { }
            public void MenuStart(User User, Account Account, string Path)

            {
                _account = Account;
                _user = User;
                _path = Path;
  restart:                      Console.WriteLine("Bank Services");
                        Console.WriteLine("choose your service");
                        Console.WriteLine();                                
                        Console.WriteLine("");
                        Console.WriteLine("1 -> Customer(new)");
                        Console.WriteLine("2 -> Account (new)");
                        Console.WriteLine("0 -> Exit");
                        _choice = Convert.ToInt16(Console.ReadLine());
                        
                        switch (_choice)
                            {
                                case 1:
                                    _user.WriteOnFile();
                                    _user.ReadOnFile();
                                    goto restart;
                                case 2:
                                    _account.WriteOnFile();
                                    _account.ReadOnFile();
                                   goto restart;
                                case 3:
                                Environment.Exit(1);
                                break;
                }
                        }
                    }
                }

            }

        

