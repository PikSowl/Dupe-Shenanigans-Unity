using UnityEngine;
using UnityEngine.Events;
using YG;

public class RestartSystem : MonoBehaviour
{
    /// <summary>
    /// Lock every unlock
    /// </summary>
    public UnityEvent LockAll;

    private void Start()
    {
        LockAll.Invoke();
    }

    public void RestartSave()
    {
        YG2.SetDefaultSaves();
        YG2.SaveProgress();
        LockAll.Invoke();
    }
}
