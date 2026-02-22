using DG.Tweening;
using UnityEngine;

public class CloudEffect : MonoBehaviour
{
    [SerializeField] private RectTransform rect;
    [SerializeField] private CanvasGroup cg;

    Vector2 startOffset = new Vector2(0, -150f); // từ dưới lên

    void Start()
    {
        Play();
    }

    void Play()
    {
        Vector2 targetPos = rect.anchoredPosition;

        rect.anchoredPosition = targetPos + startOffset;
        rect.localScale = Vector3.one * 0.8f;
        cg.alpha = 0;

        Sequence seq = DOTween.Sequence();

        seq.Append(rect.DOAnchorPos(targetPos, 1f).SetEase(Ease.OutBack));
        seq.Join(rect.DOScale(1f, 0.6f));
        seq.Join(cg.DOFade(1f, 0.6f));
        seq.AppendInterval(1.4f);

        seq.OnComplete(() => Destroy(gameObject));
    }
}
