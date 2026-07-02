using System;
using TMPro;
using YG;

/// <summary>
/// Generates 1 STR
/// </summary>

public class STRPrint : Upgrade
{
    public TMP_Text Name;
    public TMP_Text FlavorText;

    public override void ToBasic()
    {
        Name.text = "Эксперемент";
        FlavorText.text = "Может что-то открыть\n???";
        level = 0;
        StatsUpdate();
    }

    public override void StatsUpdate()
    {
        if (level == 0) level = YG2.saves.STRPrintLV;
        else            YG2.saves.STRPrintLV = level;

        if (level > 0)
        {
            Name.text = "ЗВД из Энергии";
            FlavorText.text = "Результат сложной реакции\n+1 ЗВД";
        }

        cost = 1000 * (int)(Math.Pow(10, level));
        CostText.text = cost + " Энергии";
    }
}
