using UnityEngine;
using YG;

/// <summary>
/// Controlls all operations with STR
/// </summary>

public class STR : Controller
{
    public override int Amount()
    {
        return YG2.saves.str;
    }

    public override void Produce(int amount)
    {
        YG2.saves.str += amount;
        onProduce.Invoke();
    }

    public override void Consume(int amount)
    {
        YG2.saves.str -= amount;
        onConsume.Invoke();
    }

}
