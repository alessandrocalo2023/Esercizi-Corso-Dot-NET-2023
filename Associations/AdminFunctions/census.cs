using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    public class census
    {

        //popolazione totale della regione
        long _population = 6000000;
        //porzione di popolazione per provincia
        long _portionProv;
        region _region;
        province _province;

        //numero totale dei Comuni;
       
        int _i;
        int _j;
        int _count=0;
        int _addMuni=0;



        public void Census(region RegionPop, province ProvPop)

        {

            _count = 0;
            _province = ProvPop;
            _region = RegionPop;


            Console.WriteLine("Regione: " + " " + _region.Name);
            Console.WriteLine("insert municipalities in the province of  " + " " + _province.Name);
         
            while (Console.ReadKey().Key != ConsoleKey.Enter)
         {
                _province._municSharePop[_count] = Console.ReadLine();
                _region.NameMuni[_addMuni + _count] = _province._municSharePop[_count];
                _count++;
                _region.NameMuni[_addMuni] = _province._municSharePop[_count];
            }
            _addMuni = _addMuni + _count;

            _region.numProv = _region.numProv + 1;
            _region.numMuni = _region.numMuni + _count;
            _region.ListProv[_i] = _province.Name;
            //numero di comuni per provincia
            _region.NumMuniProv[_i] = _count;
            //_region.NameMuni[_addMuni] =_province._municSharePop[_addMuni];
           // _region.NameMuni = _province._municSharePop;

            _i++;
            //_numbermunicipality = 0;

        }


        // public void CensusPrint(region RegionPopPrint, province ProvPopPrint)
        public void CensusPrint(region RegionPopShare)

        {   //_region=RegionPopPrint; 
            //_province=ProvPopPrint;

            Console.WriteLine("***************************************");
            Console.WriteLine("*** Region :" + " " + _region.Name + "***");
            Console.WriteLine("***************************************");
            //Console.WriteLine("number of municipalities:: " + " " + _numbermunicipality);
            Console.WriteLine("number of municipalities:: " + " " + _region.numMuni);

            Console.WriteLine("the total population of the region is shared below");
            for (_i = 0; _i < _region.numProv; _i++)
            {
                _portionProv = ((_population / _region.numMuni) * _region.NumMuniProv[_i]);
                Console.WriteLine("Province of:" + " " + _region.ListProv[_i] + " " + "population" + " " + _portionProv);
                
                for (_j = 0; _j <_region.numMuni; _j++)
                {
                    //_portionProv = (_population / _region.numMuni) * _region.NumMuniProv[_j];
                    Console.WriteLine("municipality of :" + " " + _region.NameMuni[_j]);
                }
                // inserimento dati comuni per provincia
            }
        }
    }
}

