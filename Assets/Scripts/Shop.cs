using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject CoalPlant;
    public TMP_Text ProduceCounter;
    public AudioSource playSound;

    public void StartCoalPlant()
    {
        playSound.Play();
        HandlerEnergy.Energy -= BasicUpgrade.cost;
        BasicUpgrade.cost *= 2;
        BasicUpgrade.prodPerSec += 1;
        BasicUpgrade.numberOfUpgrades += 1;
        ProduceCounter.text = BasicUpgrade.prodPerSec + " Энергии/сек";
        CoalPlant.SetActive(true);
    }
}
