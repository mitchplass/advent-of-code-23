public class Puzzle1Part1
{
    public static void Solution()
    {
        int totalCount = 0;
        string[] lines = File.ReadAllLines("puzzle1.txt");

        foreach (string line in lines) {
            List<char> numbersInLine = new List<char>();
            foreach (char character in line) {
                if (Char.IsDigit(character)) {
                    numbersInLine.Add(character);
                }
            }
            string numberToAdd = numbersInLine.Count == 1 ? $"{numbersInLine[0]}{numbersInLine[0]}" : $"{numbersInLine[0]}{numbersInLine[^1]}";
            totalCount += int.Parse(numberToAdd);
        }

        Console.WriteLine(totalCount);
    }
}