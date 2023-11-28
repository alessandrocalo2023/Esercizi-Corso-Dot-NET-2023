using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filewrite.Interfaces;
using System.Reflection.PortableExecutable;

namespace Filewrite.Entities
{
    internal class User:Ioperation
    {
        string line;
        string _Filename = "User.txt";
        //string _Path;
        //User _User;
        //string FilePath = @"C:\Users\Tiziana\Desktop\User.txt";

        List<string> _userList = new List<string>() { "Mario Rossi ; 45", "Aldo BAglio ; 64" ,"Giacomo Poretti ; 60",
                                                   "Giovanni Storti ; 63"};

        public void Add() { }
        public void Remove() { }
        public void Update() { }
        
       public void WriteOnFile() 
        {
            //_User = User;
            //_Path = Path;
                    
            string projectDirectory = Directory.GetCurrentDirectory();
            string FilePath = Path.Combine(projectDirectory, _Filename);
            using (StreamWriter _user = new StreamWriter(FilePath))
            {
                foreach (var user in _userList)
                { _user.WriteLine(user.ToString()); }
               // _user.Close();
            }
            
        }

        public void ReadOnFile() 
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string FilePath = Path.Combine(projectDirectory, _Filename);
            using (StreamReader _readuser = new StreamReader(FilePath))
           
                while ((line = _readuser.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            
            }
        }
    }

