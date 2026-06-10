namespace hangman;

class Game
{
    private Words words = new Words();
    private Player player = new Player();
    public void Play()
    {
        string word = words.GetRandomWord();
        while (true)
        {
            Console.Write("Uhodněte slovo (ř písmen): ");
            string guess = player.Guess();
            if (guess == word)
            {
                Console.WriteLine("Správně!");
                break;
            }
            wordleAhh(word, guess);
        }
    }
    private void wordleAhh(string word, string guess)
    {
        for (int i = 0; i < 5; i++)
        {
            if (guess[i] == word[i])
            {
                Console.Write(guess[i]);
            }
            else if (word.Contains(guess[i]))
            {
                Console.Write("?");
            }
            else
            {
                Console.Write("_");
            }
        }
        Console.WriteLine();
    }
}