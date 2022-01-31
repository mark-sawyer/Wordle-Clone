using UnityEngine;

public static class KeyInputManager {
    private static string wordInput;
    private static int wordLength;

    static KeyInputManager() { wordInput = ""; }

    public static string getWordInput() { return wordInput; }

    public static void updateWordInput(KeyCode keyPressed) {
        if (keyPressed == KeyCode.None) return;
        else if (keyPressed == KeyCode.Return) handleEnter();
        else if (keyPressed == KeyCode.Backspace) handleBackSpace();
        else handleLetter(keyPressed);
    }

    private static void handleEnter() {
        wordLength = wordInput.Length;
        if (wordLength == 5) {
            GameEvents.wordEntered.Invoke(wordInput);
            wordInput = "";
        }
    }

    private static void handleBackSpace() {
        wordLength = wordInput.Length;
        if (wordLength == 0) return;
        wordInput = wordInput.Substring(0, wordLength - 1);
        GameEvents.wordUpdated.Invoke(wordInput);
    }

    private static void handleLetter(KeyCode keyPressed) {
        wordLength = wordInput.Length;
        if (wordLength == 5) return;
        string letter = keyPressed.ToString();
        letter = letter.ToLower();
        wordInput = wordInput + letter;
        GameEvents.wordUpdated.Invoke(wordInput);
    }
}
