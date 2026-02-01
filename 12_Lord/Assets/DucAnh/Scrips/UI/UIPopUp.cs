using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIPopUp : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI amountText;
    [SerializeField] private Image iconDisplay;
    [SerializeField] private CanvasGroup canvasGroup;

    public void SetupPopUp(int amount, Sprite icon, ResourceType type)
    {
        amountText.text = $"+{amount}";

        if (iconDisplay != null && icon != null)
        {
            iconDisplay.sprite = icon;
        }

        // Logic DOTween (Giữ nguyên của bạn)
        transform.DOMoveY(transform.position.y + 100f, 1.2f).SetEase(Ease.OutQuad);
        canvasGroup.DOFade(0, 1.2f).SetDelay(0.3f).OnComplete(() => Destroy(gameObject));
    }
}