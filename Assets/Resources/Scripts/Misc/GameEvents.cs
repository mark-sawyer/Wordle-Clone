using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEvents {
    public static readonly UnityEvent<string> wordEntered = new UnityEvent<string>();
    public static readonly UnityEvent<string> wordUpdated = new UnityEvent<string>();
    public static readonly UnityEvent shortWordTried = new UnityEvent();
    public static readonly UnityEvent invalidWordTried = new UnityEvent();
    public static readonly UnityEvent flipCompleted = new UnityEvent();
    public static readonly UnityEvent revealComplete = new UnityEvent();
}
