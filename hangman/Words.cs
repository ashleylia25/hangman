namespace hangman;

public class Words
{
    private string[] words =
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

    private Random random = new Random();

    public string GetRandomWord()
    {
        return words[random.Next(words.Length)];
    }
}