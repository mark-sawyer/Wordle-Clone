using UnityEngine;
using UnityEngine.UI;
using TMPro;

public static class SquareAppearanceChanger {
    private static Sprite green;
    private static Sprite yellow;
    private static Sprite grey;
    private static Sprite blank;

    static SquareAppearanceChanger() {
        green = Resources.Load<Sprite>(Constants.GREEN_SPRITE_ADDRESS);
        yellow = Resources.Load<Sprite>(Constants.YELLOW_SPRITE_ADDRESS);
        grey = Resources.Load<Sprite>(Constants.GREY_SPRITE_ADDRESS);
        blank = Resources.Load<Sprite>(Constants.BLANK_SPRITE_ADDRESS);
    }

    public static void changeSquareColour(GameObject square, LetterColour colour) {
        Image imageComponent = square.GetComponent<Image>();
        switch (colour) {
            case LetterColour.GREEN:
                imageComponent.sprite = green;
                break;
            case LetterColour.YELLOW:
                imageComponent.sprite = yellow;
                break;
            case LetterColour.GREY:
                imageComponent.sprite = grey;
                break;
        }
    }

    public static void resetSquareAppearance(GameObject square) {
        Image imageComponent = square.GetComponent<Image>();
        imageComponent.sprite = blank;
        changeTextColour(square, Color.black);
    }

    public static void changeTextColour(GameObject square, Color colour) {
        Transform textChild = square.transform.GetChild(0);
        TextMeshProUGUI textComponent = textChild.GetComponent<TextMeshProUGUI>();
        textComponent.color = colour;
    }
}
