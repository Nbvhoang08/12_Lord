using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipDayButton : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("--- Bắt đầu ngày mới ---");
        GameEvent.TriggerSkipDay();
    }
}
