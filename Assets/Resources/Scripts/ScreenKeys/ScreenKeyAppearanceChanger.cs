using UnityEngine.UI;
using TMPro;
using UnityEngine;

public static class ScreenKeyAppearanceChanger {
    private static Sprite green;
    private static Sprite yellow;
    private static Sprite grey;
    private static Sprite normal;

    static ScreenKeyAppearanceChanger() {
        green = Resources.Load<Sprite>(Constants.GREEN_LETTER_SPRITE_ADDRESS);
        yellow = Resources.Load<Sprite>(Constants.YELLOW_LETTER_SPRITE_ADDRESS);
        grey = Resources.Load<Sprite>(Constants.GREY_LETTER_SPRITE_ADDRESS);
        normal = Resources.Load<Sprite>(Constants.NORMAL_LETTER_SPRITE_ADDRESS);
    }

    public static void update(GameObject screenKey, LetterColour colour) {
        changeFontColour(screenKey, Color.white);
        changeSpriteFromLetterColour(screenKey, colour);        
    }

    public static void reset(GameObject screenKey) {
        changeFontColour(screenKey, Color.black);
        Image image = screenKey.GetComponent<Image>();
        image.sprite = normal;
    }

    private static void changeFontColour(GameObject screenKey, Color colour) {
        Transform textChild = screenKey.transform.GetChild(0);
        TextMeshProUGUI textComponent = textChild.GetComponent<TextMeshProUGUI>();
        textComponent.color = colour;
    }

    private static void changeSpriteFromLetterColour(GameObject screenKey, LetterColour colour) {
        Image image = screenKey.GetComponent<Image>();
        switch (colour) {
            case LetterColour.GREEN:
                image.sprite = green;
                break;
            case LetterColour.YELLOW:
                image.sprite = yellow;
                break;
            case LetterColour.GREY:
                image.sprite = grey;
                break;
        }
    }
}
