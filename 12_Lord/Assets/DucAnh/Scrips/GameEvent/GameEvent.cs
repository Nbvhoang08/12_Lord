using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvent
{
    public static Action OnSkipDay;
    public static void TriggerSkipDay()
    {
        OnSkipDay?.Invoke();
    }
}
