using UnityEngine;

public static class KeyInputManager {
    private static string wordInput;
    private static int wordLength;

    static KeyInputManager() { wordInput = ""; }

    public static string getWordInput() { return wordInput; }

    public static void handleInput(KeyCode keyPressed) {
        if (keyPressed == KeyCode.None) return;
        else if (keyPressed == KeyCode.Return) handleEnter();
        else if (keyPressed == KeyCode.Backspace) handleBackSpace();
        else if (keyPressed == Constants.NEW_GAME_KEY) handleNewGame();
        else if (keyPressed == KeyCode.Escape) handleEscape();
        else handleLetter(keyPressed);
    }

    public static void resetWordInput() {
        wordInput = "";
    }

    private static void handleEnter() {
        wordLength = wordInput.Length;
        if (wordLength != 5) GameEvents.invalidWordTried.Invoke();        
        else if (!WordValidator.wordIsValid(wordInput)) GameEvents.invalidWordTried.Invoke();
        else {
            GameEvents.wordEntered.Invoke(wordInput);
            wordInput = "";
        }
    }

    private static void handleBackSpace() {
        wordLength = wordInput.Length;
        if (wordLength == 0) return;
        wordInput = wordInput.Substring(0, wordLength - 1);
        GameEvents.wordDecreased.Invoke(wordInput);
    }

    private static void handleLetter(KeyCode keyPressed) {
        wordLength = wordInput.Length;
        if (wordLength == 5) return;
        string letter = keyPressed.ToString();
        letter = letter.ToLower();
        wordInput = wordInput + letter;
        GameEvents.wordIncreased.Invoke(wordInput);
    }

    private static void handleNewGame() {
        NewGameStarter.startNewGame();
    }

    private static void handleEscape() {
        Application.Quit();
    }
}
