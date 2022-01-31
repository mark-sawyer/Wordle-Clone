using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEvents {
    public static readonly UnityEvent<string> wordEntered = new UnityEvent<string>();
    public static readonly UnityEvent<string> wordUpdated = new UnityEvent<string>();
}
