using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SceneManagment : MonoBehaviour
{
    public GameObject NotBG;
    public void LoadSimon()
    {
        NotBG.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void LoadSpeed()
    {
        //change to SpeedScene, when implemented
        NotBG.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
