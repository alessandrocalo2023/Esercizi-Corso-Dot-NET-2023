using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneServices.Entities
{
    public class Equalizer
    {
        //index of Equalizer strip
        Random rand = new Random();

        int _i;
        char _stop;

        string[] EqualizerStrip = new string[] { "******", "**********", "*******", "************", "**********", "**************" };
        Random Random = new Random();
        //implementare metodi per la visualizzazione grafica 
        // di cursori che lampeggiano o barre di frequenze
        // che oscillano 

        //in più simulare una variazione in caso di scelta
        // di più o meno bassi

        //class equalizer constructor
        public void EqualizerPrint()
        {
            //do
            {   Console.WriteLine("Bass:" + " " + EqualizerStrip[Random.Next(1, 6)]);
                Console.WriteLine("Pitch" + " " + EqualizerStrip[Random.Next(1, 6)]);
                Console.WriteLine("Volume" + " " + EqualizerStrip[3]);
                _stop = Convert.ToChar(Console.ReadKey());
            }// while (_stop =ConsoleKey.Enter);            

        }
    }
}
