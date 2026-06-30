using UnityEngine;
using TMPro;

public class CounterSystem : MonoBehaviour
{
    public TMP_Text EnergyCounter;
    public TMP_Text ProduceCounter;

    Energy energy;
    AutoGeneration generation;
    public GameObject energyController;

    private void Start()
    {
        energy = energyController.GetComponent<Energy>();
        generation = energyController.GetComponent<AutoGeneration>();
        EnergyCounterUpdate();
        ProduceCounterUpdate();
    }


    public void EnergyCounterUpdate()
    {
        EnergyCounter.text = "Энергия: " + energy.Amount();
    }

    public void ProduceCounterUpdate()
    {
        ProduceCounter.text = generation.AmountS() + " Энергии/сек";
    }
}
