using NabaGame.Core.Runtime.EventManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipDayButton : MonoBehaviour
{
    public OnSkipDayEvent SkipDayEvent;
    private void Start()
    {
        SkipDayEvent = new OnSkipDayEvent();
    }
    public void OnClick()
    {
        Debug.Log("--- Bắt đầu ngày mới ---");
        EventManager.Instance.Raise(SkipDayEvent);
    }
}
