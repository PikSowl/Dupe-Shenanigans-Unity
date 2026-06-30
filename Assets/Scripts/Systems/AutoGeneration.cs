using UnityEngine;
using UnityEngine.Events;
using YG;

public class AutoGeneration : MonoBehaviour
{
    public UnityEvent onUpdate;

    public int amountGenerated = 0;

    Energy energy;

    private void Start()
    {
        energy = GetComponent<Energy>();
        LoadAmountGenerated();
        StartGeneration();
    }

    public string AmountS()
    {
        return "" + amountGenerated;
    }

    public void LoadAmountGenerated()
    {
        amountGenerated = 1 * YG2.saves.coalPlantLV;
    }

    public void UpdateAmountGenerated()
    {
        amountGenerated = 1 * YG2.saves.coalPlantLV;
        onUpdate.Invoke();
    }

    public void StartGeneration()
    {
        InvokeRepeating(nameof(Generation), 1.0f, 1.0f);
    }


    public void Generation()
    {
        energy.Produce(amountGenerated);
    }
}
