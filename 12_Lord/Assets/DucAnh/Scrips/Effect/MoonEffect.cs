using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;

public class MoonEffect : MonoBehaviour
{

    private void OnEnable()
    {
        Play();
    }
    [Button]
    void Play()
    {
        Sequence seq = DOTween.Sequence()
            .SetLink(gameObject);

        seq.Append(transform.DOScale(1.2f, 0.5f));
        seq.AppendInterval(2f);

        seq.OnComplete(() =>
        {
            //GameManager.Instance.objectPool.ReturnMoonEffect(this);
        });
    }

    private void OnDisable()
    {
        DOTween.Kill(gameObject);
    }
}