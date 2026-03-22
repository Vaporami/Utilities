namespace Utilities;

public sealed class IO
{
    static public string Input(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
