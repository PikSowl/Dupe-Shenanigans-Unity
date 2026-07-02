using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Abstract class for upgrades
/// </summary>

[RequireComponent(typeof(Button))]

public abstract class Upgrade : MonoBehaviour
{
    public UnityEvent onBought;

    public int level = 0;
    public int cost = 1;
    public TMP_Text CostText;

    Button upgradeButton;
    Energy energy;
    public GameObject energyController;

    private void Start()
    {
        upgradeButton = GetComponent<Button>();
        energy = energyController.GetComponent<Energy>();
        StatsUpdate();
    }

    public virtual void ToBasic()
    {
        level = 0;
        StatsUpdate();
    }

    /// <summary>
    /// Needs to calculate cost and modifyer, change CostText, set level
    /// </summary>
    public abstract void StatsUpdate();


    public void Bought()
    {
        energy.Consume(cost);
        level += 1;
        StatsUpdate();
        
        onBought.Invoke();
    }


    private void Update()
    {
        if (energy.Amount() >= cost)
        {
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeButton.interactable = false;
        }
    }
}
