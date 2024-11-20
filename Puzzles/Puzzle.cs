public abstract class Puzzle
{
    public string Description { get; set; }
    public bool IsSolved { get; set; }

    public abstract bool Solve(string solution);

    public void DisplayPuzzle()
    {
        Console.WriteLine(Description);
    }
}