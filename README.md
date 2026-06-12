# Závěrečný projekt - Hangman
Můj závěrečný projekt je hra Šibenice, kterou mám ale trošku po svém a spíš funguje jak Wordle.
## Jak to funguje?
Hra vám vybere z databáze náhodné pětimístné slovo které musíte uhodnout. Když uhodnete slovo špatně, ukáže vám to, které písmena ve správném slově vůbec nejsou, které jsou na jiné pozici a které jsou na správné pozici. Když uhodnete správné slovo, vypíše se do konzole "Správně!" a hra se vypne.
Když uhodnete slovo špatně, hra vám ukáže nápovědu pro každé písmeno:
### Hinty
- `_` → písmeno se ve slově vůbec nenachází  
- `?` → písmeno se ve slově nachází, ale je na špatné pozici  
- `a` → je na správné pozici (nemusí být jenom a - je to prostě písmeno, které je uhádnuté správně) 
## AI prompty
AI mi pomohlo rozplánovat projekt do tříd, ale VĚTŠINU obsahu těchto tříd jsou selfwritten.

Tady tahle část kódu ve třídě Game.cs je vygenerovaná. AI mi vytvořilo cyklus který nám udává status každého písmene v hádaném slově (je ve slově, není ve slově, je na správném místě)

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

Dále mi jen pomohlo vysvětlit jak měnit barvy textu a vygenerovalo mi dokonce i duhovou animaci pro text "Spravne!!!", ale ten byl pro mě moc složitý a nějak se mi nedařilo tomu kódu porozumět, tak ho tam nakonec nemám.
