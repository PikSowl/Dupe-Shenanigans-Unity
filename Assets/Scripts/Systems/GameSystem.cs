using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using YG;

/// <summary>
/// AutoSave and Yandex SDK calls logic
/// </summary>

public class GameSystem : MonoBehaviour
{

    private void Start()
    {
        Debug.Log(YG2.envir.language);
        YG2.StickyAdActivity(true);
        ADBrake();
        AutoSave();
    }

    private async void AutoSave()
    {
        while (true)
        {
            await Awaitable.WaitForSecondsAsync(5.0f);
            YG2.SaveProgress();
        }
    }


    private async void ADBrake()
    {
        while (true)
        {
            await Awaitable.WaitForSecondsAsync(60.0f);
            YG2.InterstitialAdvShow();
            await Awaitable.WaitForSecondsAsync(60.0f);
        }
    }
}
