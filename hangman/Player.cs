namespace hangman;

public class Player
{
    public string Guess()
    {
        while (true)
        {
            string guess = Console.ReadLine().ToLower();
            if (guess.Length == 5)
            {
                return guess;
            }
            else
            {
                Console.WriteLine("Slovo musi mit presne 5 pismen!");
            }
        }
    }
}