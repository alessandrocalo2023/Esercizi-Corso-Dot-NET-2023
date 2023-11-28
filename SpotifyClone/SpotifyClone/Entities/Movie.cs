using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Movie
    {
        User _User;
        MovieStore _MovieStore;
        Movie _Movie;
        Mediacomponent _Mediacomponent;
        List<Movie> _MovieList=new List<Movie>();   
        int _choiceMenu;
        string _title;
        int _duration;
        string _autor;
        string _genre;
        string _qualityVideo;
        //boo to verify if the movie is suitable for Minors
        bool _SuitForMinor;

   public Movie( User User) { }

   public void MovieMenu(User User, Start Start, Song Song, string cultureinfo) 
        { 
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Movie - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("(1) Show Movie List ");
            Console.WriteLine("(2) Play - Movie");
            Console.WriteLine("(3) Manage Movies");
            Console.WriteLine("(0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    _Mediacomponent.ShowMovie(User,_MovieList);
                    break;
                case 2:
                    _Mediacomponent.PlayMovie(User,_Movie);
                    break;
                case 3:
                    _MovieStore.MovieStoreMenu();
                    break;
                case 0:
                    _User.UserMenu(User,Start,Song,cultureinfo);
                    break;
            }
   
      
    }
}
