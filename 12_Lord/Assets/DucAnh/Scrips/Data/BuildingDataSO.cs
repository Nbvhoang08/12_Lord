using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "BuildingDataSO", menuName = "Data/Building Data SO")]
public class BuildingDataSO : ScriptableObject
{
    public BuildingType buildingType;
    public ResourceType resourceType;
    string buildingName;
    public List<BuildingLevelData> levelStats;
    [SerializeField] public Sprite buildingIcon;
}

[System.Serializable]
public struct BuildingLevelData
{
    public int level;
    public int upgradeCost; // Chi phí nâng cấp
    public float buildTime; // Thời gian xây dựng
    public int capacity; // Sức chứa tài nguyên hoặc số lượng lính
    public int productionValue;
}