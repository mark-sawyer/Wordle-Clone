using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {
    public string answer;
    public GameObject thing;

    private void Start() {
        answer = WordRandomiser.getRandomWord(WordLists.answers);
    }

    private void Update() {
        KeyCode key = KeyInputDetector.returnKeyInput();
        KeyInputManager.updateWordInput(key);

        if (Input.GetKeyDown(KeyCode.Return)) {
            StartCoroutine(SquareFlipper.flip(SquareGetter.atPos(1, 1), LetterColour.GREEN));
            StartCoroutine(SquareFlipper.flip(SquareGetter.atPos(1, 2), LetterColour.GREY));
            StartCoroutine(SquareFlipper.flip(SquareGetter.atPos(1, 3), LetterColour.YELLOW));
            StartCoroutine(SquareFlipper.flip(SquareGetter.atPos(1, 4), LetterColour.GREEN));
            StartCoroutine(SquareFlipper.flip(SquareGetter.atPos(1, 5), LetterColour.YELLOW));
        }
    }
}
