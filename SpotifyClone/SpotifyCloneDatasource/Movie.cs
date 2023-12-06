using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource
{ public class Movie
    {
        string _filepath = @"C:\Users\Tiziana\Desktop\Test";
        string _filemovie = "Movie.csv";

        // public List<Movie> _MovieList = new List<Movie>();
        //int _choiceMenu;
        string _title;
        int _duration;
        string _autor;
        string _genre;
        string _qualityVideo;
        //boo to verify if the movie is suitable for Minors
        bool _SuitForMinor;

        public Movie(string Title,int Duration,string Autor,string Genre,
                     string QualityVideo, bool SuitForMinor)
        {
            _title = Title;
            _duration = Duration;
            _autor = Autor;
            _genre = Genre;
            _qualityVideo = QualityVideo;
            _SuitForMinor = SuitForMinor;
        }

        //   public void MovieMenu(User User, Start Start)
        //  {
        //   Console.WriteLine("*****************************");
        //   Console.WriteLine("*****   Movie - Menu ********");
        //   Console.WriteLine("*****************************");
        //Console.WriteLine();
        //  Console.WriteLine("(1) Show Movie List ");
        //  Console.WriteLine("(2) Play - Movie");
        //  Console.WriteLine("(3) Manage Movies");
        //  Console.WriteLine("(0) User menu");
        //  _choiceMenu = Convert.ToInt16(Console.ReadLine());
        //      switch (_choiceMenu)
        //     {
        //        case 1:
        // _Mediacomponent.ShowMovie(User, _MovieList);
        //             break;
        //        case 2:
        //_Mediacomponent.PlayMovie(User, _Movie);
        //            break;
        //        case 3:
        // _MovieStore.MovieStoreMenu();
        //             break;
        //        case 0:
        //            _User.UserMenu(User, Start);
        //            break;
    }


}
   


