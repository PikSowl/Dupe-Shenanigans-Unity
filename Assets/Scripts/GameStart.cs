using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public static bool isLoading = false;

    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(2);
    }
}
