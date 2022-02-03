using UnityEngine;

public class SquareRevealer : MonoBehaviour {
    private int revealedSoFar;
    private LetterColour[] revealColours;

    private void Start() {
        GameEvents.flipCompleted.AddListener(reveal);
        GameEvents.wordEntered.AddListener(startRevealing);
    }

    private void startRevealing(string wordEntered) {
        revealedSoFar = 0;
        revealColours = WordComparer.compareWords(AnswerHolder.getAnswer(), wordEntered);
        reveal();
    }

    private void reveal() {
        if (revealedSoFar == 5) {
            GameEvents.revealComplete.Invoke();
            RowManager.incrementRow();
            return;
        }

        GameObject squareToFlip = SquareGetter.atPos(RowManager.getRow(), revealedSoFar + 1);
        StartCoroutine(SquareFlipper.flip(squareToFlip, revealColours[revealedSoFar]));
        revealedSoFar++;
    }

    public void startReveal(LetterColour[] colours) {
        revealColours = colours;
        reveal();
    }
}
