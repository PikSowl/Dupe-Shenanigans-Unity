using System;
using YG;

/// <summary>
/// Controlls all operations with energy
/// </summary>

public class Energy : Controller
{
    public override int Amount()
    {
        return YG2.saves.energy;
    }

    public void ClickProduce()
    {
        int amountGenerated = YG2.saves.staticLV;
        amountGenerated *= (int)Math.Pow(2, YG2.saves.dupeAnomalyLV);
        Produce(amountGenerated);
    }

    public override void Produce(int amount)
    {
        YG2.saves.energy += amount;
        onProduce.Invoke();
    }

    public override void Consume(int amount)
    {
        YG2.saves.energy -= amount;
        onConsume.Invoke();
    }

}
