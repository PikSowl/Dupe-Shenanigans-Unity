using System;
using UnityEngine;
using UnityEngine.Events;
using YG;

/// <summary>
/// Contains all auto generation logic
/// </summary>

[RequireComponent(typeof(Energy))]
public class AutoGeneration : MonoBehaviour
{
    public UnityEvent onUpdate;

    public int amountGenerated = 0;

    Energy energy;

    private void Start()
    {
        energy = GetComponent<Energy>();
        UpdateAmountGenerated();
        StartGeneration();
    }

    public string AmountS()
    {
        return "" + amountGenerated;
    }

    public void UpdateAmountGenerated()
    {
        amountGenerated = YG2.saves.coalMineLV * YG2.saves.coalPlantLV;
        amountGenerated *= (int)Math.Pow(2, YG2.saves.dupeAnomalyLV);
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
