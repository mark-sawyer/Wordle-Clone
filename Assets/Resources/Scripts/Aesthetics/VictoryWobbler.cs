using System.Collections;
using UnityEngine;

public class VictoryWobbler : MonoBehaviour {
    private void Start() {
        GameEvents.wordFound.AddListener(startWobbleSequence);
    }

    private void startWobbleSequence() {
        StartCoroutine(wobbleSequence());
    }

    private IEnumerator wobbleSequence() {
        int rowJustUsed = RowManager.getRow() - 1;
        RowReorderer.makeRowLast(rowJustUsed);
        GameObject square;
        for (int col = 1; col <= Constants.NUMBER_OF_LETTERS; col++) {
            square = SquareGetter.atPos(rowJustUsed, col);
            SquareWobbler.victoryWobble(square);
            yield return new WaitForSeconds(0.15f);
        }
    }
}
