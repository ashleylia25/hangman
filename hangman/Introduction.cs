namespace hangman;

public class Introduction
{
    public void Show()
    {
        Console.Clear();
        Console.WriteLine("HANGMAN");
        Console.WriteLine("Uhádněte pětimístné slovo.");
        Console.WriteLine("Máte 6 pokusů.");
        Console.WriteLine();
        Console.WriteLine("Stiskněte libovolnou klávesu pro začátek...");
        Console.ReadKey();
    }
}