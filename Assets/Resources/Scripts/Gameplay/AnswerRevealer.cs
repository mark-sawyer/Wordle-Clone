using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerRevealer : MonoBehaviour {
    private TextMeshProUGUI textComponent;

    private void Start() {
        textComponent = GetComponent<TextMeshProUGUI>();
        textComponent.text = AnswerHolder.getAnswer().ToUpper();
        GameEvents.playerLost.AddListener(startAnswerReveal);
        GameEvents.newGameStarted.AddListener(newGameReset);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            newGameReset();
        }
    }

    private void startAnswerReveal() {
        StartCoroutine(revealAnswer());
    }

    private IEnumerator revealAnswer() {
        Color fontColour = textComponent.color;
        float increment = 0.005f;
        while (fontColour.a < 1) {
            fontColour.a += increment;
            textComponent.color = fontColour;
            yield return null;
        }
    }

    private void newGameReset() {
        StopAllCoroutines();
        textComponent.text = AnswerHolder.getAnswer().ToUpper();
        textComponent.color = new Color(0, 0, 0, 0);
    }
}
