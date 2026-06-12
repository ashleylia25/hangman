namespace hangman;

public class Words
{
    private string[] _words =
    {
        "tungs",
        "grape",
        "train",
        "zuzan",
        "green",
        "genug",
        "sahur",
        "kitty",
        "trees",
        "audio",
        "crane",
        "ghost",
        "maybe",
        "jazzy",
        "honza",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
        "horse",
    };

    private Random _random = new Random();

    public string GetRandomWord()
    {
        return _words[_random.Next(_words.Length)];
    }
}