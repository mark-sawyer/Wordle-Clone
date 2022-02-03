using UnityEngine;

public class ClassInitialiser : MonoBehaviour {
    // Problem getting static classes to listen to events through a static constructor.
    // Resolve by initialising in a Start() function.

    void Start() {
        SquareTyper.initialiseSquareTyper();
        AnswerHolder.getNewAnswer();
    }
}
