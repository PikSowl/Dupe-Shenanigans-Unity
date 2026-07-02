using System;
using YG;

/// <summary>
/// Clicking Generation upgrade 1 
/// Each one is +1Energy/click
/// </summary>

public class StaticEnergy : Upgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.staticLV;
        else            YG2.saves.staticLV = level;

        cost = 7 * (int)(Math.Pow(1.7, level));
        CostText.text = cost + " Энергии";
    }
}
