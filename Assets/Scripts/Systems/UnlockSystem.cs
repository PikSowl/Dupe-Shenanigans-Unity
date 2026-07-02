using System;
using UnityEngine;
using UnityEngine.Events;
using YG;

/// <summary>
/// Unlocks various Mechanics:
/// </summary>
/*
    STR Module unlocks when first STR gained
    Simon Mini-game unlocks with forge upgrade
    ReactionSpeed Mini-game unlocks with forge upgrade
*/

public class UnlockSystem : MonoBehaviour
{
    public UnityEvent STRUnlocked;
    public UnityEvent SimonMGUnlocked;
    public UnityEvent SpeedMGUnlocked;

    void Start()
    {
        UnlockSTR();
        UnlockSimonMG();
        UnlockSpeedMG();
    }
    public void UnlockSTR()
    {
        Debug.Log("Unlock");
        if (YG2.saves.STRPrintLV != 0)
        {
            STRUnlocked.Invoke();
        }
    }
    public void UnlockSimonMG()
    {
        if (YG2.saves.simonExperementLV != 0)
        {
            SimonMGUnlocked.Invoke();
        }
    }
    public void UnlockSpeedMG()
    {
        if (YG2.saves.speedExperementLV != 0)
        {
            SpeedMGUnlocked.Invoke();
        }
    }
}
