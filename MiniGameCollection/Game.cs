using System.Reflection;

namespace MiniGameCollection;

public class Game
{
    const string Title = "░█▄█░▀█▀░█▀█░▀█▀░░░█▀▀░█▀█░█▄█░█▀▀░░░█▀▀░█▀█░█░░░█░░░█▀▀░█▀▀░▀█▀░▀█▀░█▀█░█▀█\r\n░█░█░░█░░█░█░░█░░░░█░█░█▀█░█░█░█▀▀░░░█░░░█░█░█░░░█░░░█▀▀░█░░░░█░░░█░░█░█░█░█\r\n░▀░▀░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀░░░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░░▀░░▀▀▀░▀▀▀░▀░▀\n";

    private readonly List<IMiniGame> miniGames;
    private string filter = string.Empty;

    public Game()
    {
        miniGames = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(IMiniGame).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract).Select(t => (IMiniGame)Activator.CreateInstance(t)!).ToList();
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();

            var filteredGames = GetFilteredGames();

            DrawMenu(filteredGames);

            Console.WriteLine("\nOptions:");
            Console.WriteLine("  [number] Select game");
            Console.WriteLine("  [s]   Search / Filter games");
            Console.WriteLine("  [c]   Clear filter");
            Console.WriteLine("  [q]   Quit");
            Console.Write("\nEnter choice: ");

            string input = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

            if (input == "q")
            {
                break;
            }
            else if (input == "s")
            {
                Console.Write("Enter search term: ");
                filter = Console.ReadLine()?.Trim() ?? string.Empty;
            }
            else if (input == "c")
            {
                filter = string.Empty;
            }
            else if (int.TryParse(input, out int choice) && choice > 0 && choice <= filteredGames.Count)
            {
                PlayGameLoop(filteredGames[choice - 1]);
            }
        }
    }

    private List<IMiniGame> GetFilteredGames()
    {
        if (string.IsNullOrWhiteSpace(filter))
        {
            return miniGames;
        }

        return miniGames.Where(game => game.Name.Contains(filter, StringComparison.OrdinalIgnoreCase) || game.Description.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    private void DrawMenu(List<IMiniGame> games)
    {
        Console.WriteLine(Title);

        if (!string.IsNullOrEmpty(filter))
        {
            Console.WriteLine($"[Filter: \"{filter}\"]\n");
        }

        if (games.Count == 0)
        {
            Console.WriteLine("No minigames match your search.");
            return;
        }

        for (int i = 0; i < games.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {games[i].Name} - {games[i].Description}");
        }
    }

    private void PlayGameLoop(IMiniGame game)
    {
        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.Clear();
            Console.WriteLine($"=== {game.Name} ===");
            Console.WriteLine($"{game.Description}\n");

            game.Run();

            Console.Write("\nPlay again? (y/n): ");
            string playAgain = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
            if (playAgain != "y")
            {
                keepPlaying = false;
            }
        }
    }
}