using MovieDatabaseLab;

List<Movie> movies = new List<Movie>
{
    new Movie("Blade Runner 2049", "scifi"),
    new Movie("Star War: Revenge of the sith", "scifi"),
    new Movie("Scream", "horror"),
    new Movie("Big Hero 6", "animated"),
    new Movie("Spiderman: Into the spider-verse", "animated"),
    new Movie("Oppenheimer", "drama"),
    new Movie("Creed 3", "drama"),
    new Movie("The Pope's Exorcist", "horror"),
    new Movie("Nope", "scifi"),
    new Movie("Talk to me", "horror")
};

bool repeat = true;
while (repeat)
{
    Console.WriteLine("Please enter a movie category (animated, drama, horror, or scifi");
    string userCategory = Console.ReadLine().Trim().ToLower();

    bool validCategory = userCategory == "animated" || userCategory == "drama" || userCategory == "horror" || userCategory == "scifi";
    
    if (!validCategory)
    {
        Console.WriteLine("Oops you entered an invalid category. Please enter a valid category");
    }
    else
    {
        List<Movie> matchingMovies = movies.FindAll(movie => movie.Category == userCategory);

        if (matchingMovies.Count == 0)
        {
            Console.WriteLine("No movies found in the entered category.");
        }
        else
        {
            Console.WriteLine("Movies in the entered category: ");
            foreach (var movie in matchingMovies)
            {
                Console.WriteLine($"Title: {movie.Title}, Category: {movie.Category}");
            }
        }
    }
    Console.WriteLine("Would you like to continue? (yes/no): ");
    string continueChoice = Console.ReadLine();
    repeat = continueChoice == "yes";
}
Console.WriteLine("Bye Bye!");
