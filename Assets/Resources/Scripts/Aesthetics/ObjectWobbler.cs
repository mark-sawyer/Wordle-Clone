using System.Collections;
using UnityEngine;

public class ObjectWobbler : MonoBehaviour {
    public void startWobble(float amplitude, int shakesNum, float timeInSeconds, bool isVertical) {
        StartCoroutine(wobble(amplitude, shakesNum, timeInSeconds, isVertical));
    }

    private IEnumerator wobble(float amplitude, int shakesNum, float timeInSeconds, bool isVertical) {
        Vector3 initialPos = transform.localPosition;
        float xScalar = (2 * shakesNum * Mathf.PI) / timeInSeconds;
        float offset;
        for (float t = 0; t < timeInSeconds; t += Time.deltaTime) {
            offset = amplitude * Mathf.Sin(xScalar * t);
            transform.localPosition = initialPos + getOffsetVector(isVertical, offset);

            yield return null;
        }

        transform.localPosition = initialPos;
    }

    private Vector3 getOffsetVector(bool isVertical, float offset) {
        if (isVertical) return new Vector3(0f, offset);
        else return new Vector3(offset, 0f);
    }
}
