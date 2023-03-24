using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class MovieLib
    {
        Movies movie1 = new Movies()
        {
            Name = "Avengers:Endgame",
            Description = "Avengers: Endgame is a 2019 American superhero film based on the Marvel Comics superhero team the Avengers. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the direct sequel to Avengers: Infinity War (2018) and the 22nd film in the Marvel Cinematic Universe (MCU). Directed by Anthony and Joe Russo and written by Christopher Markus and Stephen McFeely, the film features an ensemble cast including Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner, Don Cheadle, Paul Rudd, Brie Larson, Karen Gillan, Danai Gurira, Benedict Wong, Jon Favreau, Bradley Cooper, Gwyneth Paltrow, and Josh Brolin. In the film, the surviving members of the Avengers and their allies attempt to reverse Thanos's actions in Infinity War.",
            Genre = "Sci-fi, action",
            Price = 0
        };
        Movies movie2 = new Movies()
        {
            Name = "Jurassic Park",
            Description = "Jurassic Park, later also referred to as Jurassic World,[1] is an American science fiction media franchise created by Michael Crichton and centered on a disastrous attempt to create a theme park of cloned dinosaurs. It began in 1990 when Universal Pictures and Amblin Entertainment bought the rights to Crichton's novel Jurassic Park before it was published. The book was successful, as was Steven Spielberg's 1993 film adaptation. The film received a theatrical 3D re-release in 2013,[2] and was selected in 2018 for preservation in the United States National Film Registry by the Library of Congress as being \"culturally, historically, or aesthetically significant\". A 1995 sequel novel, The Lost World, was followed by a film adaptation in 1997. Subsequent films in the series, including Jurassic Park III (2001), are not based on the novels.",
            Genre = "Sci-fi",
            Price = 1500
        };

        public void MovieList()
        {
            Console.WriteLine($"Available movies: 1.{movie1.Name}\n\t\t  2.{movie2.Name}");
        }

        public void MovieInfoPrint()
        {
            Console.Write("Choose movie: ");
            int movieNumber = Convert.ToInt32(Console.ReadLine());
            switch(movieNumber)
            {
                case 1:
                    {
                        Console.WriteLine($"Name: {movie1.Name} \nGenre: {movie1.Genre} \nPrice: {movie1.Price} \n\tDescription: {movie1.Description}");
                        break;
                    }
                case 2: 
                    {
                        Console.WriteLine($"Name: {movie2.Name} \nGenre: {movie2.Genre} \nPrice: {movie2.Price} \n\tDescription: {movie2.Description}");
                        break;
                    }
            }
            
        }
        //public enum Movie
        //{
        //    Movie1,
        //    Movie2,
        //    Movie3,
        //}
    }
}
