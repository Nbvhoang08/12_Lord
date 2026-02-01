using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ResourceBuilding : Building
{
    public static event Action<ResourceBuilding, int> OnCollectAll;

    public override void Start()
    {
        base.Start();
        GameEvent.OnSkipDay += HandleSkipDay;
    }

    private void HandleSkipDay()
    {
        // Lấy chỉ số từ SO
        int index = currentLevel - 1;
        int productionAmount = 0;
        if (buildingData != null && index < buildingData.levelStats.Count)
        {
            productionAmount = buildingData.levelStats[index].productionValue;
        }

        OnCollectAll?.Invoke(this, productionAmount);
    }
}
