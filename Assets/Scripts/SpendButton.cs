using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpendButton: MonoBehaviour
{
    public GameObject statusBox;

    public void ClickTheButton ()
    {
        HandlerEnergy.Energy -= 1;
    }
}
