using System.Threading;
using UnityEngine;
using YG;

public class GameSystem : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(YG2.envir.language);
        YG2.GameReadyAPI();
        YG2.StickyAdActivity(true);
        ADBrake();
        AutoSave();
    }

    private async void AutoSave()
    {
        while (true)
        {
            await Awaitable.WaitForSecondsAsync(5f);
            YG2.SaveProgress();
        }
    }


    private async void ADBrake()
    {
        while (true)
        {
            await Awaitable.WaitForSecondsAsync(60f);
            YG2.InterstitialAdvShow();
        }
    }
}
