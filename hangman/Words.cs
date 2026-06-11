namespace hangman;

public class Words
{
    private string[] _words =
    {
        "tungs",
        "grape",
        "horse",
        "train",
        "zuzan",
        "green",
        "genug",
        "sahur"
    };

    private Random _random = new Random();

    public string GetRandomWord()
    {
        return _words[_random.Next(_words.Length)];
    }
}