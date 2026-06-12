namespace hangman;

class Game
{
    private Words _words = new Words();
    private Player _player = new Player();
    public void Play(int maxAttempts)
    {
        string secretWord = _words.GetRandomWord();
        int guessesLeft = maxAttempts;
        while (guessesLeft > 0)
        {
            Console.Write($"Hadejte slovo. (Zbyva {guessesLeft} pokusu): ");
            string guess = _player.Guess();
            if (guess == secretWord)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Spravne!!!");
                Console.ResetColor();
                return;
            } else if (guess.Length != secretWord.Length)
            {
                Console.WriteLine("Musite hadat slova, ktera maji pet pismen. Zkuste to znovu.");
            }
            WordleAhh(secretWord, guess);
            guessesLeft--;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Konec hry! Spravne slovo bylo {secretWord}.");
        Console.ResetColor();
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