using System;
using YG;

/// <summary>
/// Auto Energy Generation upgrade 1
/// Each one is +1Energy/sec
/// </summary>

public class CoalPlant : Upgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.coalPlantLV;
        else            YG2.saves.coalPlantLV = level;

        cost = 10 + 10 * (int)(Math.Pow(1.8, level));
        CostText.text = cost + " Энергии";
    }
}
