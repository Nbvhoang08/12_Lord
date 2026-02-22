using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMoonEffect : UICanvas
{
    void Start()
    {
        UIManager.Instance.CloseUI<UIMoonEffect>(2.5f);
    }
}
