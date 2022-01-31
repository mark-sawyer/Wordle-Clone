using UnityEngine;

public static class SquareGetter {
    public static GameObject atPos(int row, int col) {
        string gameObjectName = "letter_" + row.ToString() + col.ToString();
        GameObject square = GameObject.Find(gameObjectName);
        return square;
    }
}
