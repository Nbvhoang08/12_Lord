using UnityEngine;


public abstract class Building : MonoBehaviour
{
    public BuildingDataSO buildingData;
    [SerializeField] protected int currentLevel = 1;

    public virtual void Start() { }
    public virtual void Update() { }
}