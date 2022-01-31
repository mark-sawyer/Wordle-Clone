using UnityEngine;

public class ClassInitialiser : MonoBehaviour {
    // Problem getting SquareTyper to listen to an event through a static constructor.
    // Resolve by initialising in a Start() function.

    void Start() {
        SquareTyper.initialiseSquareTyper();
    }
}
