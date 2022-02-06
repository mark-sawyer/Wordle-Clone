using UnityEngine;

public static class SquareTyper {
    public static void initialiseSquareTyper() {
        GameEvents.wordIncreased.AddListener(increase);
        GameEvents.wordDecreased.AddListener(updateText);
    }

    private static void increase(string word) {
        updateText(word);
        int length = word.Length;
        GameObject square = SquareGetter.atPos(RowManager.getRow(), length);
        square.GetComponent<ObjectBulger>().startBulge();
    }

    private static void updateText(string word) {
        int wordLength = word.Length;
        char charToUse;
        GameObject square;
        for (int i = 0; i < Constants.NUMBER_OF_LETTERS; i++) {
            if (i >= wordLength) charToUse = ' ';
            else charToUse = word[i];

            square = SquareGetter.atPos(RowManager.getRow(), i + 1);
            SquareLetterUpdater.update(square, charToUse);
        }
    }
}
