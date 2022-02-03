
using System;

public static class WordValidator {
    private static string[] validGuesses;

    static WordValidator() {
        int answersTotal = WordLists.answers.Length;
        int onlyGuessesTotal = WordLists.onlyGuesses.Length;
        int totalAllowableGuesses = onlyGuessesTotal + answersTotal;
        validGuesses = new string[totalAllowableGuesses];
        Array.Copy(WordLists.answers, validGuesses, answersTotal);
        Array.Copy(WordLists.onlyGuesses, 0, validGuesses, answersTotal, onlyGuessesTotal);
    }

    public static bool wordIsValid(string guess) {
        bool b = false;
        foreach (string validGuess in validGuesses) {
            if (guess == validGuess) {
                b = true;
                break;
            }
        }
        return b;
    }
}
