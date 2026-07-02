using YG;

/// <summary>
/// Unlocks ReactionSpeed Mini-game
/// </summary>

public class SpeedExperiment : ForgeUpgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.speedExperementLV;
        else YG2.saves.speedExperementLV = level;


        if (level > 0)
        {
            cost = 99999;
            CostText.text = "Только\nодин";
        }
        else
        {
            cost = 5;
            CostText.text = cost + " ЗВД";
        }
    }
}
