using System;
using UnityEngine;

public class GameUpdater : MonoBehaviour {
    private Action gameUpdater;

    private void Start() {
        gameUpdater = allowInput;
        GameEvents.wordEntered.AddListener(turnOffInput);
        GameEvents.invalidWordTried.AddListener(turnOffInput);
        GameEvents.inputAllowed.AddListener(turnOnInput);
        GameEvents.newGameStarted.AddListener(turnOnInput);
        GameEvents.playerLost.AddListener(turnOnNewGameInput);
        GameEvents.victoryWobbleComplete.AddListener(turnOnNewGameInput);
    }

    private void Update() {
        gameUpdater();
    }

    private void allowInput() {
        KeyCode key = detectInput();
        KeyInputManager.handleInput(key);
    }

    private void allowNewGameInput() {
        KeyCode key = detectInput();
        if (key == Constants.NEW_GAME_KEY | key == KeyCode.Escape) KeyInputManager.handleInput(key);
    }
    private void allowEscapeInput() {
        KeyCode key = detectInput();
        if (key == KeyCode.Escape) KeyInputManager.handleInput(key);
    }

    private void turnOffInput(string s) {
        gameUpdater = allowEscapeInput;
    }

    private void turnOffInput() {
        gameUpdater = allowEscapeInput;
    }

    private void turnOnInput() {
        gameUpdater = allowInput;
    }

    private void turnOnNewGameInput() {
        gameUpdater = allowNewGameInput;
    }

    private KeyCode detectInput() {
        KeyCode key = KeyInputDetector.returnKeyInput();
        if (key == KeyCode.None) key = MouseInputDetector.returnMouseInput();
        return key;
    }
}
