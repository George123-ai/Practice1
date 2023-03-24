namespace FilmBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Movies movie = new Movies();

            MovieLib movie = new MovieLib();
            
            bool again = true;
            do
            {
                Console.Clear();
                Console.Write("Main menu: 1)Movie list. 2)Find movie. 3)Exit. --> ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            movie.MovieList();
                            Console.Write(" (Options) 1)Main menu. 2)Get info about movie. 3)Watch movie--> ");
                            int choice1 = int.Parse(Console.ReadLine());
                            Console.Clear() ;
                            if (choice1 == 1)
                            {
                                //again= true;
                                continue;
                            }
                            else if (choice1 == 2)
                            {
                                movie.MovieList();
                                movie.MovieInfoPrint();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to go to main menu...");
                                Console.ReadKey();
                            }
                            
                            break;
                        }
                        case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Find movie func is not ready yet...");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to go to main menu...");
                            Console.ReadKey();
                            break;
                        }
                        case 3:
                        {
                            again= false;
                            break;
                        }
                }
            } while (again);
            

            
        }
    }
}