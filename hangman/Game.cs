namespace hangman;

class Game
{
    private Words _words = new Words();
    private Player _player = new Player();
    public void Play()
    {
        string secretWord = _words.GetRandomWord();
        int guessesLeft = 6;
        while (guessesLeft > 0)
        {
            Console.Write($"Hádejte slovo. (Zbývá {guessesLeft} pokusů): ");
            string guess = _player.Guess();
            if (guess == secretWord)
            {
                Console.WriteLine("You win!");
                return;
            } else if (guess.Length != secretWord.Length)
            {
                Console.WriteLine("Musíte hádat slova, které mají pět písmen. Zkuste to znovu.");
            }
            WordleAhh(secretWord, guess);
            guessesLeft--;
        }
        Console.WriteLine($"Konec hry! Správné slovo bylo {secretWord}");
    }
    private void WordleAhh(string word, string guess)
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