using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField] private GameObject PopUpPrefab;
    [SerializeField] private Transform PopUpParent;
    public int wood, stone, iron;

 

    private void AddResource(ResourceBuilding building, int amount)
    {
        switch (building.buildingData.resourceType)
        {
            case ResourceType.Wood: wood += amount; break;
            case ResourceType.Stone: stone += amount; break;
            case ResourceType.Iron: iron += amount; break;
        }
        GameObject go = Instantiate(PopUpPrefab, building.transform.position, Quaternion.identity, PopUpParent);

        UIPopUp popUpScript = go.GetComponent<UIPopUp>();
        if (popUpScript != null)
        {
            popUpScript.SetupPopUp(amount, building.buildingData.buildingIcon, building.buildingData.resourceType);
     
        }
    }
}
