using UnityEngine;

public class ClassInitialiser : MonoBehaviour {
    // Problem getting static classes to listen to events through a static constructor.
    // Resolve by initialising in a Start() function.

    void Awake() {
        SquareTyper.initialiseSquareTyper();
        WordEnteredResolver.initialiseWordEnteredResolver();
        ScreenKeyUpdater.initialiseScreenKeyUpdater();
        SquareWobbler.initialiseSquareWobbler();

        RowManager.initialiseRowManager();  // This must be before the GameOverChecker initialisation
        GameOverChecker.initialiseGameOverChecker();

        AnswerHolder.getNewAnswer();
    }
}
