using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEvents {
    public static readonly UnityEvent<string> wordEntered = new UnityEvent<string>();
    public static readonly UnityEvent<string> wordIncreased = new UnityEvent<string>();
    public static readonly UnityEvent<string> wordDecreased = new UnityEvent<string>();
    public static readonly UnityEvent invalidWordTried = new UnityEvent();
    public static readonly UnityEvent wordFound = new UnityEvent();
    public static readonly UnityEvent inputAllowed = new UnityEvent();
    public static readonly UnityEvent flipCompleted = new UnityEvent();
    public static readonly UnityEvent revealComplete = new UnityEvent();
    public static readonly UnityEvent victoryWobbleComplete = new UnityEvent();
    public static readonly UnityEvent newGameStarted = new UnityEvent();
}
