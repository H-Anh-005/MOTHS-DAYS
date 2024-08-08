using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void OnLevelClick(int level)
    {
        // Chuyển sang màn chơi tương ứng
        SceneManager.LoadScene("Level" + level.ToString());
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
