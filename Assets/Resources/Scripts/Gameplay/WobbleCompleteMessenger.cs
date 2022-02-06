using System.Collections;
using UnityEngine;

public class WobbleCompleteMessenger : MonoBehaviour {
    private void Start() {
        GameEvents.invalidWordTried.AddListener(getErrorCompleteMessageReady);
        GameEvents.wordFound.AddListener(getVictoryCompleteMessageReady);
    }

    private void getErrorCompleteMessageReady() {
        StartCoroutine(turnOnInputAfterErrorWobble());
    }

    private void getVictoryCompleteMessageReady() {
        StartCoroutine(alertVictoryWobbleComplete());
    }

    private IEnumerator turnOnInputAfterErrorWobble() {
        yield return new WaitForSeconds(Constants.ERROR_WOBBLE_SECONDS);

        GameEvents.inputAllowed.Invoke();
    }

    private IEnumerator alertVictoryWobbleComplete() {
        yield return new WaitForSeconds(Constants.VICTORY_WOBBLE_SECONDS);

        GameEvents.victoryWobbleComplete.Invoke();
    }
}
