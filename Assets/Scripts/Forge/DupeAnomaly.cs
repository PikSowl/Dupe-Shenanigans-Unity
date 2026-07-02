using YG;

/// <summary>
/// All Energy Generation upgrade
/// Multiply all produce by 2*DupeAnomaly.level
/// </summary>

public class DupeAnomaly : ForgeUpgrade
{
    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.dupeAnomalyLV;
        else YG2.saves.dupeAnomalyLV = level;

        cost = 2 * (level + 1);
        CostText.text = cost + " ЗВД";
    }
}
