using UnityEngine;

public static class ScreenKeyGetter {
    public static GameObject getScreenKey(char c) {
        string letter = c.ToString().ToUpper();
        GameObject screenKey = GameObject.Find(letter);
        return screenKey;
    }
}
