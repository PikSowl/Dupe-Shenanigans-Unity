using UnityEngine;
using YG;

public class Energy : Controller
{
    public override int Amount()
    {
        return YG2.saves.energy;
    }

    public void ClickProduce()
    {
        Produce(YG2.saves.generatorLV);
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
