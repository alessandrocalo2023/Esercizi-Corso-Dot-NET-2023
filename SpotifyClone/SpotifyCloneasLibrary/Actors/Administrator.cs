using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Administrator

    { int _choiceMenu;
        // uso questa bool per impedire la cancellazione dell'utente se è anche admin
        bool _adminFlag;
        User AdminUserCheck;
        Start _Start;
        public Administrator() { }




        //in questa classe implemento i metodi di caricamento Song da dispositivo esterno
        //per simulazione utilizzeroò un file Excel;
        // e operazioni di pura amministrazione come cambio password e aggiunta nuovo utente

        public void AdminMenu(User User, Start Start, Song Song) {
            AdminUserCheck = User;
            Console.WriteLine("***************************************");
            Console.WriteLine("*****   Administrator Console  ********");
            Console.WriteLine("***************************************");
            if (AdminUserCheck._adminflag == true)
                Console.WriteLine(" Welcome"+" "+ "admin:" + AdminUserCheck._name + " " + AdminUserCheck._surname);
            else {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("- Warning - you are not an administrator -");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("please try again");
                AdminUserCheck.UserMenu(User, Start, Song);
            }

            Console.WriteLine();
            Console.WriteLine("1) Change password");
            Console.WriteLine("2) Add User");
            Console.WriteLine("3) Remove User");
            Console.WriteLine("0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    Console.WriteLine("Insert new password:" + " ");
                            break;
                case 0:
                    AdminUserCheck.UserMenu(User, Start, Song);
                    break;
            } }
        public void ChangePass() { }
        public void NewUser() { }
        public void RemoveUser() { }
    }
}

   

