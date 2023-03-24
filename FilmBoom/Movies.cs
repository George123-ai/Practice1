using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Movies:MovieProps
    {
        public string Name { get ; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public decimal Price { get ; set; }
        public string Actors { get; set; }

        //public void MovieLib()
        //{
        //    Movies movie1 = new Movies();
        //    movie1.Name = "Avengers:Endgame";
        //    movie1.Description = "Avengers: Endgame is a 2019 American superhero film based on the Marvel Comics superhero team the Avengers. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the direct sequel to Avengers: Infinity War (2018) and the 22nd film in the Marvel Cinematic Universe (MCU). Directed by Anthony and Joe Russo and written by Christopher Markus and Stephen McFeely, the film features an ensemble cast including Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner, Don Cheadle, Paul Rudd, Brie Larson, Karen Gillan, Danai Gurira, Benedict Wong, Jon Favreau, Bradley Cooper, Gwyneth Paltrow, and Josh Brolin. In the film, the surviving members of the Avengers and their allies attempt to reverse Thanos's actions in Infinity War.";
        //    movie1.Genre = "Sci-fi, action";
        //    movie1.Price = 0;

        //}

        public Movies()
        {
        }

        //public void MovieInfoPrint(Movies movie) 
        //{
        //    MovieLib();
        //    Console.WriteLine($"Name: {movie.Name} \nDescription: {movie} \nGenre: {movie.Genre} \nPrice: {movie.Price}");
        //}

        //public enum Genre
        //{

        //}
    }
}
