namespace FilmBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Movies movie = new Movies();

            MovieLib movieInfo = new MovieLib();
            movieInfo.MovieList();
            movieInfo.MovieInfoPrint(); 

            
        }
    }
}