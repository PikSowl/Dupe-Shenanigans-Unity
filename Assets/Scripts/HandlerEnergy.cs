using UnityEngine;
using TMPro;

public class HandlerEnergy: MonoBehaviour
{
    public static int Energy;
    public TMP_Text EnergyCounter;
    public int InternalEnergy;


    void Update ()
    {
        InternalEnergy = Energy;
        EnergyCounter.text = "Энергия: " + InternalEnergy;
    }
    
}
