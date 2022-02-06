using UnityEngine;

public static class KeyInputDetector {
    private static KeyCode[] allowedKeys = new KeyCode[30] {
        KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D,
        KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H,
        KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L,
        KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P,
        KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T,
        KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X,
        KeyCode.Y, KeyCode.Z, KeyCode.Return, KeyCode.Backspace,
        KeyCode.Escape, Constants.NEW_GAME_KEY
    };
    private static bool keyWasPressed;
    private static KeyCode keyPressed;

    public static KeyCode returnKeyInput() {
        keyWasPressed = false;
        keyPressed = KeyCode.None;
        foreach (KeyCode key in KeyInputDetector.allowedKeys) {
            keyWasPressed = Input.GetKeyDown(key);
            if (keyWasPressed) {
                keyPressed = key;
                break;
            }
        }
        return keyPressed;
    }
}
