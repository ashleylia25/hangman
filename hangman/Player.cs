namespace hangman;

public class Player
{
    public string Guess()
    {
        string guess;

        do
        {
            guess = Console.ReadLine().ToLower();
        }
        while (guess.Length != 5);

        return guess;
    }
}