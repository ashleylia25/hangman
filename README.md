# Závěrečný projekt - Hangman
Můj závěrečný projekt je hra Šibenice, kterou mám ale trošku po svém a spíš funguje jako Wordle.

## Jak to funguje?
Hra vám vybere z databáze náhodné pětimístné slovo, které musíte uhodnout. Když uhodnete slovo špatně, ukáže vám, která písmena ve správném slově vůbec nejsou, která jsou na jiné pozici a která jsou na správné pozici. Když uhodnete správné slovo, vypíše se do konzole "Správně!" a hra se vypne.

Když uhodnete slovo špatně, hra vám ukáže nápovědu pro každé písmeno:

### Hinty
- `_` → písmeno se ve slově vůbec nenachází  
- `?` → písmeno se ve slově nachází, ale je na špatné pozici  
- `a` → je na správné pozici (nemusí být jenom „a“ – je to prostě písmeno, které je uhádnuté správně)

### Další funkce
- **Výběr obtížnosti** – hráč si na začátku hry vybírá obtížnosti Easy, Medium a Hard (1, 2, 3) – obtížnost spočívá v počtu pokusů na uhádnutí správného slova  
- **Ošetřený vstup** – když hráč napíše slovo, které je kratší nebo delší než 5 písmen, hra ho upozorní, že musí hádat jen pětimístná slova, a neubere mu pokus  
- **Barevný text** – v úvodu jsou obtížnosti zabarvené do zelena, žluta a červena. Dále jsou barevné i texty, které se zobrazí, když hráč úspěšně uhádne slovo a když prohraje  
- **Horse** – ve hře mám napsaná některá vlastní slova, která hráč může dostat, ale má také 50% šanci, že slovo, které dostane, je "horse"

## AI prompty
AI mi pomohlo rozplánovat projekt do tříd, ale většina obsahu těchto tříd je self-written.

Tady tahle část kódu ve třídě Game.cs je vygenerovaná. AI mi vytvořilo cyklus, který určuje status každého písmene v hádaném slově (je ve slově, není ve slově, je na správném místě):

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

Dále mi AI jen pomohlo vysvětlit, jak měnit barvy textu, a vygenerovalo mi dokonce i duhovou animaci pro text "Správně!!!", ale ta byla pro mě moc složitá a nedařilo se mi tomu kódu porozumět, takže ji tam nakonec nemám.
