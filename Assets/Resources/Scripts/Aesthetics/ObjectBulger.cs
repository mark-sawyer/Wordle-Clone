using System.Collections;
using UnityEngine;

public class ObjectBulger : MonoBehaviour {
    public void startBulge() {
        StartCoroutine(bulge());
    }

    private IEnumerator bulge() {
        Vector3 initialScale = transform.localScale;
        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(Constants.BULGE_FACTOR, Constants.BULGE_FACTOR, 1));
        while (transform.localScale.x > initialScale.x) {
            yield return null;
            transform.localScale -= new Vector3(0.02f, 0.02f);
        }
        transform.localScale = initialScale;
    }
}
