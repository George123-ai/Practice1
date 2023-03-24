namespace FilmBoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Movies movie = new Movies();

            MovieLib movie = new MovieLib();
            //movieInfo.MovieList();
            //movieInfo.MovieInfoPrint(); 
            bool again = true;
            do
            {
                Console.Write("Main menu: 1)Movie list. 2)Find movie. 3)Exit. --> ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            movie.MovieList();
                            Console.Write(" (Options) 1)Main menu. 2)Get info about movie. 3)Watch movie 4)Exit --> ");
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
                            }
                            else if (choice == 4)
                            {
                                again = false;
                                return;
                                //Environment.Exit(0);
                            }
                            break;
                        }
                }
            } while (again);
            //Console.Write("Main menu: 1)Movie list. 2)Find movie. 3)Exit. --> ");
            //int choice = int.Parse(Console.ReadLine()); 

            //switch(choice) 
            //{
            //    case 1:
            //        {
            //            Console.Clear();
            //            movie.MovieList();
            //            Console.WriteLine(" (Where) 1)Main menu. 2)Get info about movie. 3)Watch movie 4)Exit --> ");
            //            int choice1 = int.Parse(Console.ReadLine());
            //            if (choice1 == 1) { 

            //            }
            //            break;
            //        }
            //}

            
        }
    }
}