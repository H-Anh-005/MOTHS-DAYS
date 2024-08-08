using UnityEngine.SceneManagement;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public void OnLoginClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
