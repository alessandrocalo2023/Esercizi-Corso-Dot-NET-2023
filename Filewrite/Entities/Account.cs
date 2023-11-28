using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filewrite.Interfaces;

namespace Filewrite.Entities
{
    internal class Account : Ioperation
    {
        string line; 
        string _Filename = "Account.txt";
        //string _Path;
        //Account _Account;
        //string FilePath = @"C:\Users\Tiziana\Desktop\Account.txt";

        List<string> _accountList = new List<string>() { "IT60K0014804589000000012547 ; 15.000","IT60K0014804589000000048751 ; 1.000",
                                                      "IT60K0014804589000000000542 ; 130.000","IT60K0014804589000000000487 ; 120.000" };

        public void Add() { }
        public void Remove() { }
        public void Update() { }

        public void WriteOnFile()
        {
            // _Account = Account;
            //_Path = Path;

            string projectDirectory = Directory.GetCurrentDirectory();
            string FilePath = Path.Combine(projectDirectory, _Filename);
            using (StreamWriter _account = new StreamWriter(FilePath))
            {
                foreach (var account in _accountList)
                { _account.WriteLine(account.ToString()); 
                }
               
              
            }
        }


        public void ReadOnFile()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string FilePath = Path.Combine(projectDirectory, _Filename);
            using (StreamReader _readaccount = new StreamReader(FilePath))
            
                while ((line = _readaccount.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            
        }
    }
}

