using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public void OnEasyClick()
    {
        // Lưu cài đặt
        PlayerPrefs.SetString("Difficulty", "Easy");
    }

    public void OnNormalClick()
    {
        PlayerPrefs.SetString("Difficulty", "Normal");
    }

    public void OnHardClick()
    {
        PlayerPrefs.SetString("Difficulty", "Hard");
    }

    public void OnDifficultClick()
    {
        PlayerPrefs.SetString("Difficulty", "Difficult");
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
