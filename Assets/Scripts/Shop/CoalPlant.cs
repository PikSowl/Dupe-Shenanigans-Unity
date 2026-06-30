using System;


public class CoalPlant : Upgrade
{
    public override void ChangeCost()
    {
        cost = 10 * (int)(Math.Pow(2.0, level));
        CostText.text = cost + " Энергии";
    }

    public override void ChangeMod()
    {
        modifier += 1;
    }


}
