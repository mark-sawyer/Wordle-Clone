using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class SquareLetterUpdater {
    public static void update(GameObject square, char letter) {
        string capitalLetter = letter.ToString().ToUpper();
        Transform textTransform = square.transform.GetChild(0);
        TextMeshProUGUI textComponent = textTransform.GetComponent<TextMeshProUGUI>();
        textComponent.text = capitalLetter;
    }

    public static void reset(GameObject square) {
        Transform textTransform = square.transform.GetChild(0);
        TextMeshProUGUI textComponent = textTransform.GetComponent<TextMeshProUGUI>();
        textComponent.text = "";
    }
}
