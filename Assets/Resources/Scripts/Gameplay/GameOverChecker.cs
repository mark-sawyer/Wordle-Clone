using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public static class GameOverChecker {
    public static void initialiseGameOverChecker() {
        GameEvents.revealComplete.AddListener(checkIfOver);
    }

    private static void checkIfOver() {
        // RowManager has already incremented.
        if (allSquaresAreGreen()) {
            GameEvents.wordFound.Invoke();
        }
        else if (RowManager.getRow() - 1 < Constants.NUMBER_OF_ROWS) {
            GameEvents.inputAllowed.Invoke();
        }
        else {
            GameEvents.playerLost.Invoke();
        }
    }

    private static bool allSquaresAreGreen() {
        bool allGreen = true;
        GameObject square;
        Sprite colour;
        for (int col = 1; col <= Constants.NUMBER_OF_LETTERS; col++) {
            square = SquareGetter.atPos(RowManager.getRow() - 1, col);
            colour = square.GetComponent<Image>().sprite;
            if (colour != Resources.Load<Sprite>(Constants.GREEN_SPRITE_ADDRESS)) {
                allGreen = false;
                break;
            }
        }

        return allGreen;
    }
}
