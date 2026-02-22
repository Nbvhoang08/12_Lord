using UnityEngine;
using DG.Tweening;

public class SunParabolaEffect : MonoBehaviour
{
    [Header("Parabola Settings")]
    public Vector2 startPos;      // Vị trí bắt đầu
    public Vector2 endPos;        // Vị trí kết thúc
    public float height = 300f;   // Độ cao đỉnh parabol
    public float duration = 1.5f;// Thời gian bay

    [Header("Optional Rotate")]
    public bool rotate = true;
    public float rotateAngle = 180f;

    private RectTransform rect;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    void Start()
    {
        Play();
    }

    public void Play()
    {
        rect.anchoredPosition = startPos;

        Sequence seq = DOTween.Sequence();

        // X di chuyển thẳng
        seq.Join(
            rect.DOAnchorPosX(endPos.x, duration)
                .SetEase(Ease.Linear)
        );

        // Y di chuyển theo parabol
        seq.Join(
            DOTween.To(
                () => 0f,
                t =>
                {
                    // Công thức parabol
                    float yOffset = 4 * height * t * (1 - t);
                    float y = Mathf.Lerp(startPos.y, endPos.y, t) + yOffset;

                    rect.anchoredPosition = new Vector2(
                        rect.anchoredPosition.x,
                        y
                    );
                },
                1f,
                duration
            ).SetEase(Ease.Linear)
        );

        // Xoay mặt trời (tuỳ chọn)
        if (rotate)
        {
            seq.Join(
                rect.DORotate(
                    new Vector3(0, 0, rotateAngle),
                    duration,
                    RotateMode.FastBeyond360
                )
            );
        }
    }
}
