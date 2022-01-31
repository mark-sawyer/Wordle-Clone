using UnityEngine;
using UnityEngine.UI;

public static class SquareImageChanger {
    private static Sprite green;
    private static Sprite yellow;
    private static Sprite grey;
    private static Sprite blank;

    static SquareImageChanger() {
        green = Resources.Load<Sprite>("Sprites/green");
        yellow = Resources.Load<Sprite>("Sprites/yellow");
        grey = Resources.Load<Sprite>("Sprites/grey");
        blank = Resources.Load<Sprite>("Sprites/blank");
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
}
