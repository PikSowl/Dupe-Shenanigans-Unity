using System;
using YG;

/// <summary>
/// Auto Energy Generation upgrade 2
/// Multiply CoalPlant produce by CoalMine.level
/// </summary>

public class CoalMine : Upgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.coalMineLV;
        else            YG2.saves.coalMineLV = level;

        cost = 100 * (int)(Math.Pow(2, level));
        CostText.text = cost + " Энергии";
    }
}
