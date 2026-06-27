using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicUpgrade : MonoBehaviour
{
    public Button UpgradeButton;
    public TMP_Text CostText;
    public int currentEnergy;
    public static int cost = 10;


    void Update()
    {
        currentEnergy = HandlerEnergy.Energy;
        CostText.text = cost.ToString();
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
