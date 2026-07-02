using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// Abstract class for Forge upgrades
/// </summary>

[RequireComponent(typeof(Button))]

public abstract class ForgeUpgrade : MonoBehaviour
{
    public UnityEvent onBought;

    public int level = 0;
    public int cost = 1;
    public TMP_Text CostText;

    Button upgradeButton;
    STR st_r;
    public GameObject strController;

    private void Start()
    {
        upgradeButton = GetComponent<Button>();
        st_r = strController.GetComponent<STR>();
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
        st_r.Consume(cost);
        level += 1;
        StatsUpdate();
        
        onBought.Invoke();
    }


    private void Update()
    {
        if (st_r.Amount() >= cost)
        {
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeButton.interactable = false;
        }
    }
}
