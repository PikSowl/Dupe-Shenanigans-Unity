using System;
using YG;

/// <summary>
/// Generates 1 STR and rols ad
/// </summary>

public class ADPrint : Upgrade
{
    public string rewardID;

    public void TryBuying()
    {
        YG2.RewardedAdvShow(rewardID, () =>Bought());
    }

    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.ADPrintLV;
        else            YG2.saves.ADPrintLV = level;

        cost = 100 * (int)(Math.Pow(5, level));
        CostText.text = cost + " Энергии";
    }
}
