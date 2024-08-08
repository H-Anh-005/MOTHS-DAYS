using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void OnPlayClick()
    {
        SceneManager.LoadScene("Play");
    }

    public void OnLevelClick()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnSettingsClick()
    {
        SceneManager.LoadScene("Settings");
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene("Login");
    }
}
