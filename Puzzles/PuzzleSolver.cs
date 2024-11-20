public class PuzzleSolver
{
    public static bool SolvePuzzle(Puzzle puzzle)
    {
        puzzle.DisplayPuzzle();

        Console.Write("Enter your solution: ");
        string playerSolution = Console.ReadLine();

        return puzzle.Solve(playerSolution);
    }
}