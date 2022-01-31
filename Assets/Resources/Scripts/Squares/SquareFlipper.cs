using System.Collections;
using UnityEngine;

public static class SquareFlipper {
    public static IEnumerator flip(GameObject square, LetterColour colour) {
        for (float angle = 0; angle <= 90; angle += Constants.ANGLE_CHANGE_PER_FRAME) {
            square.transform.localEulerAngles = new Vector3(angle, 0, 0);
            yield return null;
        }

        SquareImageChanger.changeSquareColour(square, colour);
        SquareTextColourChanger.changeColour(square, Color.white);

        for (float angle = 90; angle >= 0; angle -= Constants.ANGLE_CHANGE_PER_FRAME) {
            square.transform.localEulerAngles = new Vector3(angle, 0, 0);
            yield return null;
        }
    }
}
