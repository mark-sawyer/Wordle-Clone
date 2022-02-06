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
        if (key == Constants.NEW_GAME_KEY) KeyInputManager.handleInput(key);
    }

    private void turnOffInput(string s) {
        gameUpdater = () => { };
    }

    private void turnOffInput() {
        gameUpdater = () => { };
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
