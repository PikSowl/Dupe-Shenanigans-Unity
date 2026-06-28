using UnityEngine;

public class Load : MonoBehaviour
{

    void Start()
    {
        if (GameStart.isLoading)
        {
            HandlerEnergy.Energy = PlayerPrefs.GetInt("SavedEnergy");
            BasicUpgrade.numberOfUpgrades = PlayerPrefs.GetInt("SavedCoalGen");
        }
    }

}
