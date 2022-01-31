using UnityEngine;
using TMPro;

public static class SquareTextColourChanger {
    public static void changeColour(GameObject square, Color colour) {
        Transform textChild = square.transform.GetChild(0);
        TextMeshProUGUI textComponent = textChild.GetComponent<TextMeshProUGUI>();
        textComponent.color = colour;
    }
}
