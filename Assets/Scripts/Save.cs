using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{

    void Start()
    {
        InvokeRepeating(nameof(SaveGame), 0, 5.0f);
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("SavedEnergy", HandlerEnergy.Energy);
        PlayerPrefs.SetInt("SavedCoalGen", BasicUpgrade.numberOfUpgrades);
    }
}
