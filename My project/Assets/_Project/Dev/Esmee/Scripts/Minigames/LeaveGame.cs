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

    public void GoMain()
    {
        SceneManager.LoadScene("AboutUs-ggis");
    }

    public void Page2()
    {
        SceneManager.LoadScene("Page2");
    }

    public void Page1()
    {
        SceneManager.LoadScene("InfectedFish");
    }
}
