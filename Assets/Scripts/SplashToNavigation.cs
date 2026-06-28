using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToNavigation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(NavMenu());
    }

    IEnumerator NavMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

}
