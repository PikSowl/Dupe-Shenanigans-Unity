using System.Net;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using System;

public class HandlerCoalPlant : MonoBehaviour
{
    public bool CreatingEnergy = false;
    public static int EnergyIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        EnergyIncrease = BasicUpgrade.prodPerSec;
        InternalIncrease = EnergyIncrease;
        if (CreatingEnergy == false)
        {
            CreatingEnergy = true;
            StartCoroutine(CreateSomeEnergy());
        }
    }

    IEnumerator CreateSomeEnergy ()
    {
        HandlerEnergy.Energy += EnergyIncrease;
        yield return new WaitForSeconds(1);
        CreatingEnergy = false;
    }
}
