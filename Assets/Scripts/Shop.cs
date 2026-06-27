using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject CoalPlant;

    public void StartCoalPlant()
    {
        HandlerEnergy.Energy -= BasicUpgrade.cost;
        BasicUpgrade.cost *= 2;
        CoalPlant.SetActive(true);
    }
}
