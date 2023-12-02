public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Which puzzle to run?");
        string? puzzleToRun = Console.ReadLine();

        switch (puzzleToRun) {
            case "Puzzle1Part1":
                Puzzle1Part1.Solution();
                break;
            default:
                Console.WriteLine("Not a valid puzzle.");
                break;
        }
    }
}