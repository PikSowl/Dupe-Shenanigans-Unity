using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using YG;

public abstract class Upgrade : MonoBehaviour
{
    public UnityEvent onBought;

    public int level = 0;
    public int cost = 1;
    public int modifier = 0;
    public Button UpgradeButton;
    public TMP_Text CostText;

    Energy energy;
    public GameObject energyController;

    private void Start()
    {
        energy = energyController.GetComponent<Energy>();
        level = YG2.saves.coalPlantLV;
        ChangeCost();
        ChangeMod();
    }

    public abstract void ChangeCost();

    public abstract void ChangeMod();

    public void Bought()
    {
        energy.Consume(cost);
        level += 1;
        YG2.saves.coalPlantLV = level;
        ChangeCost();
        ChangeMod();
        
        onBought.Invoke();
    }


    private void Update()
    {
        if (energy.Amount() >= cost)
        {
            UpgradeButton.interactable = true;
        }
        else
        {
            UpgradeButton.interactable = false;
        }
    }
}
