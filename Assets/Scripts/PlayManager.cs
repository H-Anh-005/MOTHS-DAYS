using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public void OnStoryModeClick()
    {
        SceneManager.LoadScene("StoryMode");
    }

    public void OnSurvivalModeClick()
    {
        SceneManager.LoadScene("SurvivalMode");
    }

    public void OnCharactersClick()
    {
        SceneManager.LoadScene("Characters");
    }

    public void OnInventoryClick()
    {
        SceneManager.LoadScene("Inventory");
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
