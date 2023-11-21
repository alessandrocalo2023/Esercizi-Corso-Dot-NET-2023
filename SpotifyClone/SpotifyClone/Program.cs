using SpotifyClone.Entities;
using System;
using SpotifyClone.Interfaces;

namespace SpotifyClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            song TestSong = new song("Coming back to life",120);
            mediacomponent.Play(TestSong);
            int _choice;
            Console.WriteLine("Welcome to your favorite Media Player ");
            Console.WriteLine("Please select your media source");
            Console.WriteLine("1) Web");
            Console.WriteLine("2) SD memory");
            Console.WriteLine("3) Radio");
            _choice=Convert.ToInt16(Console.ReadLine());
        }
    }
}
