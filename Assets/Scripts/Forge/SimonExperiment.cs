using System.Xml.Linq;
using YG;

/// <summary>
/// Unlocks Simon Mini-game
/// </summary>

public class SimonExperiment : ForgeUpgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.simonExperementLV;
        else YG2.saves.simonExperementLV = level;

        if (level > 0)
        {
            cost = 99999;
            CostText.text = "Только\nодин";
        }
        else
        {
            cost = 1;
            CostText.text = cost + " ЗВД";
        }
    }
}
