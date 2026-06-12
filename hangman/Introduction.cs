namespace hangman;

public class Introduction
{
    public int Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("HANGMAN");
            Console.WriteLine("Zvolte si obtiznost a uhadnete petimistne slovo.");
            Console.WriteLine("1. Easy (9 pokusu)");
            Console.WriteLine("2. Medium (7 pokusu)");
            Console.WriteLine("3. Hard (5 pokusu)");
            string diff = Console.ReadLine();
            if (diff == "1")
            {
                return 9;
            }
            else if (diff == "2")
            {
                return 7;
            }
            else if (diff == "3")
            {
                return 5;
            }
            else
            {
                Console.WriteLine("Neplatna volba! Zvolte 1, 2 nebo 3.");
                Console.ReadKey();
            }
        }
    }
}