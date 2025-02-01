using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("FishPage");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("StartPage");
    }
}
