using UnityEngine;

public class SquareRevealer : MonoBehaviour {
    private int revealedSoFar;
    private LetterColour[] revealColours;

    private void Start() {
        GameEvents.flipCompleted.AddListener(reveal);
    }

    public void startRevealing(LetterColour[] colours) {
        revealedSoFar = 0;
        revealColours = colours;
        reveal();
    }

    private void reveal() {
        if (revealedSoFar == 5) {
            GameEvents.revealComplete.Invoke();
            return;
        }

        GameObject squareToFlip = SquareGetter.atPos(RowManager.getRow(), revealedSoFar + 1);
        StartCoroutine(SquareFlipper.flip(squareToFlip, revealColours[revealedSoFar]));
        revealedSoFar++;
    }
}
