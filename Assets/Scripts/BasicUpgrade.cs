using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;

public class BasicUpgrade : MonoBehaviour
{
    public Button UpgradeButton;
    public TMP_Text CostText;
    public int currentEnergy;
    public static int cost = 10;
    public static int numberOfUpgrades = 0;
    public static int prodPerSec = 0;



    void Update()
    {
        cost = 10 * (int)(Math.Pow(2.0, numberOfUpgrades));
        prodPerSec = numberOfUpgrades;
        currentEnergy = HandlerEnergy.Energy;
        CostText.text = cost + "\nЭнергии";
        if (currentEnergy >= cost)
        {
            UpgradeButton.interactable = true;
        }
        else
        {
            UpgradeButton.interactable = false;
        }
    }
}
