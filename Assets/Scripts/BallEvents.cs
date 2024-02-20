using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEvents : MonoBehaviour
{
    public static event Action OnGameOver;

    public static void TriggerGameOver()
    {
        OnGameOver?.Invoke();
    }
}
