using UnityEngine;
using System.Collections.Generic;
using Sirenix.OdinInspector;

[System.Serializable]
public class RawBuilding 
{
	public BuildingType BuildingType;
	public int productivity;
}

public class RawBuildingData : ScriptableObject 
{
    [TableList]
    public List<RawBuilding> rawBuildings = new List<RawBuilding>();
}
