using UnityEngine;

public static class NewGameStarter {
    public static void startNewGame() {
        RowManager.resetRow();
        KeyInputManager.resetWordInput();
        AnswerHolder.getNewAnswer();
        GameEvents.newGameStarted.Invoke();
        resetSquares();
        resetScreenKeys();
    }

    private static void resetSquares() {
        GameObject square;
        for (int col = 1; col <= Constants.NUMBER_OF_LETTERS; col++) {
            for (int row = 1; row <= Constants.NUMBER_OF_ROWS; row++) {
                square = SquareGetter.atPos(row, col);
                SquareAppearanceChanger.resetSquareAppearance(square);
                SquareLetterUpdater.reset(square);
            }
        }
    }

    private static void resetScreenKeys() {
        GameObject screenKey;
        foreach (char letter in Constants.LETTERS) {
            screenKey = ScreenKeyGetter.getScreenKey(letter);
            ScreenKeyAppearanceChanger.reset(screenKey);
        }
    }
}
