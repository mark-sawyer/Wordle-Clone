using System;
using UnityEngine;

public class GameUpdater : MonoBehaviour {
    private Action gameUpdater;
    private SquareRevealer squareRevealer;

    private void Start() {
        squareRevealer = GetComponent<SquareRevealer>();
        gameUpdater = allowInput;
        GameEvents.wordEntered.AddListener(turnOffInput);
        GameEvents.revealComplete.AddListener(turnOnInput);
    }

    private void Update() {
        gameUpdater();
    }

    private void allowInput() {
        KeyCode key = KeyInputDetector.returnKeyInput();
        KeyInputManager.updateWordInput(key);
    }

    private void turnOffInput(string s) {
        gameUpdater = () => { };
    }

    private void turnOnInput() {
        gameUpdater = allowInput;
    }
}
