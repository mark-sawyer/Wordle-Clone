using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public static class ScreenKeyUpdater {
    private static string word;
    private static LetterColour[] letterColours;

    public static void initialiseScreenKeyUpdater() {
        GameEvents.revealComplete.AddListener(updateScreenKeys);
    }

    public static void getData(string s, LetterColour[] lc) {
        word = s;
        letterColours = lc;
    }

    private static void updateScreenKeys() {
        char c;
        LetterColour colour;
        for (int i = 0; i < Constants.NUMBER_OF_LETTERS; i++) {
            c = word[i];
            colour = letterColours[i];
            GameObject screenKey = ScreenKeyGetter.getScreenKey(c);
            ScreenKeyStatus status = getKeyStatus(screenKey);
            resolveKey(screenKey, status, colour);
        }
    }

    private static void resolveKey(GameObject screenKey, ScreenKeyStatus status, LetterColour colour) {
        switch (status) {
            case ScreenKeyStatus.GREEN:
                break;
            case ScreenKeyStatus.YELLOW:
                if (colour == LetterColour.GREEN) ScreenKeyAppearanceChanger.update(screenKey, colour);
                break;
            case ScreenKeyStatus.GREY:
                break;
            case ScreenKeyStatus.NORMAL:
                ScreenKeyAppearanceChanger.update(screenKey, colour);
                break;
        }
    }

    private static ScreenKeyStatus getKeyStatus(GameObject screenKey) {
        ScreenKeyStatus status = ScreenKeyStatus.NORMAL;
        Sprite sprite = screenKey.GetComponent<Image>().sprite;
        if (sprite == Resources.Load<Sprite>(Constants.GREEN_LETTER_SPRITE_ADDRESS)) status = ScreenKeyStatus.GREEN;
        else if (sprite == Resources.Load<Sprite>(Constants.YELLOW_LETTER_SPRITE_ADDRESS)) status = ScreenKeyStatus.YELLOW;
        else if (sprite == Resources.Load<Sprite>(Constants.GREY_LETTER_SPRITE_ADDRESS)) status = ScreenKeyStatus.GREY;
        return status;
    }
}
