using DG.Tweening;
using NabaGame.Core.Runtime.EventManager;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBuilding : Building
{
    public BuildingType buildingType;
    [SerializeField] private TextMeshPro amountText;
    public Transform popup;

    private void OnEnable()
    {
        EventManager.Instance.AddListener<OnSkipDayEvent>(HandleSkipDay);
    }
    private void OnDisable()
    {
        EventManager.Instance.RemoveListener<OnSkipDayEvent>(HandleSkipDay);
    }


    private void HandleSkipDay(OnSkipDayEvent e = null)
    {
        // Lấy chỉ số từ SO
        if(buildingType== BuildingType.MainHouse) return;
        RawBuilding rawBuilding = GameManager.Instance.GetData(buildingType);
        SetupPopUp(rawBuilding.productivity);
    }
    public void SetupPopUp(int amount)
    {
        popup.gameObject.SetActive(true);
        popup.transform.localPosition = Vector3.zero;
        amountText.text = $"+{amount}";
        popup.DOMoveY(transform.position.y + 1f, 0.7f).SetEase(Ease.OutQuad).OnComplete(() => { popup.gameObject.SetActive(false); });
    }
}
