using System;
using CINEMA.Managers;


namespace CINEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager mm = new MovieManager();

            foreach (var item in mm.GetAllMovies())
            {
                Console.WriteLine(item.Title);
            }

           
        }
    }
}
