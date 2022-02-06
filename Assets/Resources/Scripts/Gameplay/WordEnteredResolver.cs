using UnityEngine;

public static class WordEnteredResolver {
    private static SquareRevealer squareRevealer;

    public static void initialiseWordEnteredResolver() {
        squareRevealer = GameObject.Find(Constants.MANAGER_GAMEOBJECT).GetComponent<SquareRevealer>();
        GameEvents.wordEntered.AddListener(resolve);
    }

    private static void resolve(string word) {
        LetterColour[] letterColours = WordComparer.compareWords(AnswerHolder.getAnswer(), word);
        ScreenKeyUpdater.getData(word, letterColours);
        squareRevealer.startRevealing(letterColours);
    }
}
