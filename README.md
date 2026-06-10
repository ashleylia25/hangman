# Závěrečný projekt - Hangman
Můj závěrečný projekt je hra Šibenice, kterou mám ale trošku po svém a spíš funguje jak Wordle.
## Jak to funguje?
Hra vám vybere z databáze náhodné pětimístné slovo které musíte uhodnout. Když uhodnete slovo špatně, ukáže vám to, které písmena ve správném slově vůbec nejsou, které jsou na jiné pozici a které jsou na správné pozici. Když uhodnete správné slovo, vypíše se do konzole "Správně!" a hra se vypne.
## Plánované funkce
- Výběr obtížnosti (5 pokusů, 7 pokusů, 9 pokusů)
- Barvy
- Úvod na začátek
- Ošetření inputu hráče
- Možnost hrát znovu
## AI prompty
AI mi pomohlo vytvořit cyklus který nám udává status každého písmene (je ve slově, není ve slově, je na správném místě)

```
private void ShowHints(string secretWord, string guess)
{
    for (int i = 0; i < 5; i++)
    {
        if (guess[i] == secretWord[i])
            Console.Write(guess[i]);
        else if (secretWord.Contains(guess[i]))
            Console.Write("?");
        else
            Console.Write("_");
    }

    Console.WriteLine();
}
```

Tento kód mám ale podle své potřeby upravený.
