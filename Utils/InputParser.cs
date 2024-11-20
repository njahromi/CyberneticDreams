public class InputParser
{
    public static string ParseInput()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        return input.ToLower();
    }
}