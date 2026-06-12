namespace hangman;
class Program
{
    static void Main(string[] args)
    {
        Introduction intro = new Introduction();
        Game game = new Game();
        int attempts = intro.Show();
        game.Play(attempts);
    }
}