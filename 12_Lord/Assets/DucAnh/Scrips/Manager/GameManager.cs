using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : Singleton<GameManager>
{
    public ObjectPool objectPool;
    public RawBuildingData buildingData;



    public RawBuilding GetData(BuildingType t) 
    {
        return buildingData.rawBuildings[(int)t];
    }


}
