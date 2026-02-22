using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Object Pool", menuName = "GameData/Pool", order = 1)]
public class ObjectPool : ScriptableObject
{

    public MoonEffect moonEffect;
    public MoonEffect GetMoonEffect(Vector3 position, Quaternion rotation, Transform parent)
    {
        return FastPoolManager.
        GetPool(moonEffect.gameObject).
        FastInstantiate<MoonEffect>(position, rotation, parent);
    }
    public void ReturnMoonEffect(MoonEffect moonEffect)
    {
        FastPoolManager.
        GetPool(moonEffect.gameObject).
        FastDestroy(moonEffect.gameObject);
    }
}
