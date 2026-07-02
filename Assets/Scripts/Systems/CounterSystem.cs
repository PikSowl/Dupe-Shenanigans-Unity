using UnityEngine;
using TMPro;

/// <summary>
/// Updates displayed info on recources and generation of them
/// </summary>

public class CounterSystem : MonoBehaviour
{
    public TMP_Text EnergyCounter;
    public TMP_Text ProduceCounter;
    public TMP_Text STRCounter;
    
    AutoGeneration generation;
    Energy energy;
    public GameObject energyController;
    STR st_r;
    public GameObject strController;

    private void Start()
    {
        energy = energyController.GetComponent<Energy>();
        generation = energyController.GetComponent<AutoGeneration>();
        st_r = strController.GetComponent<STR>();
        EnergyCounterUpdate();
        STRCounterUpdate();
        ProduceCounterUpdate();
    }


    public void EnergyCounterUpdate()
    {
        EnergyCounter.text = "Энергия: " + energy.Amount();
    }

    public void STRCounterUpdate()
    {
        STRCounter.text = "ЗВД: " + st_r.Amount();
    }

    public void ProduceCounterUpdate()
    {
        ProduceCounter.text = generation.AmountS() + " Энергии/сек";
    }
}
