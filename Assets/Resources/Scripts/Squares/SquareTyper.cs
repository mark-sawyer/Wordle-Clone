using UnityEngine;

public static class SquareTyper {
    public static void initialiseSquareTyper() {
        GameEvents.wordUpdated.AddListener(updateWord);
    }

    private static void updateWord(string word) {
        int wordLength = word.Length;
        char charToUse;
        GameObject square;
        for (int i = 0; i < Constants.LETTER_NUM; i++) {
            if (i >= wordLength) charToUse = ' ';
            else charToUse = word[i];

            square = SquareGetter.atPos(RowManager.getRow(), i + 1);
            SquareLetterUpdater.update(square, charToUse);
        }
    }
}
