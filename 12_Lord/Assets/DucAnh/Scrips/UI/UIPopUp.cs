using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIPopUp : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI amountText;
    [SerializeField] private Image iconDisplay;

    public void SetupPopUp(int amount, Sprite icon, ResourceType type)
    {
        amountText.text = $"+{amount}";

        if (iconDisplay != null && icon != null)
        {
            iconDisplay.sprite = icon;
        }

        // Logic DOTween (Giữ nguyên của bạn)
        transform.DOMoveY(transform.position.y + 1f, 1f).SetEase(Ease.OutQuad);
    }
}