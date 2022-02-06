using TMPro;
using UnityEngine;

public static class ScreenKeyToKeyCode {
    public static KeyCode getKeyCode(GameObject screenKey) {
        Transform textChild = screenKey.transform.GetChild(0);
        TextMeshProUGUI textComponent = textChild.GetComponent<TextMeshProUGUI>();
        string text = textComponent.text;
        return screenKeyTextToKeyCode(text);
    }

    private static KeyCode screenKeyTextToKeyCode(string text) {
        KeyCode key = KeyCode.None;
        switch (text) {
            case "A":
                key = KeyCode.A;
                break;
            case "B":
                key = KeyCode.B;
                break;
            case "C":
                key = KeyCode.C;
                break;
            case "D":
                key = KeyCode.D;
                break;
            case "E":
                key = KeyCode.E;
                break;
            case "F":
                key = KeyCode.F;
                break;
            case "G":
                key = KeyCode.G;
                break;
            case "H":
                key = KeyCode.H;
                break;
            case "I":
                key = KeyCode.I;
                break;
            case "J":
                key = KeyCode.J;
                break;
            case "K":
                key = KeyCode.K;
                break;
            case "L":
                key = KeyCode.L;
                break;
            case "M":
                key = KeyCode.M;
                break;
            case "N":
                key = KeyCode.N;
                break;
            case "O":
                key = KeyCode.O;
                break;
            case "P":
                key = KeyCode.P;
                break;
            case "Q":
                key = KeyCode.Q;
                break;
            case "R":
                key = KeyCode.R;
                break;
            case "S":
                key = KeyCode.S;
                break;
            case "T":
                key = KeyCode.T;
                break;
            case "U":
                key = KeyCode.U;
                break;
            case "V":
                key = KeyCode.V;
                break;
            case "W":
                key = KeyCode.W;
                break;
            case "X":
                key = KeyCode.X;
                break;
            case "Y":
                key = KeyCode.Y;
                break;
            case "Z":
                key = KeyCode.Z;
                break;
            case "ENTER":
                key = KeyCode.Return;
                break;
            case "NEW GAME":
                key = Constants.NEW_GAME_KEY;
                break;
            default:
                key = KeyCode.Backspace;
                break;
        }
        return key;
    }
}
