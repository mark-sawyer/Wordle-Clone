using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SquareWobbler {
    public static void initialiseSquareWobbler() {
        GameEvents.invalidWordTried.AddListener(errorWobble);
    }

    public static void victoryWobble(GameObject square) {
        square.GetComponent<ObjectWobbler>().startWobble(60f, 1, 0.75f, true);
    }

    public static void errorWobble() {
        for (int colPos = 1; colPos <= Constants.NUMBER_OF_LETTERS; colPos++) {
            GameObject square = SquareGetter.atPos(RowManager.getRow(), colPos);
            square.GetComponent<ObjectWobbler>().startWobble(3f, 4, Constants.ERROR_WOBBLE_SECONDS, false);
        }
    }
}
