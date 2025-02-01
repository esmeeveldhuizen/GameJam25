using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherSceneOrder : MonoBehaviour
{
    public void Scene0()
    {
        SceneManager.LoadScene("FishPage");
    }
    public void Minigame1()
    {
        SceneManager.LoadScene("FishGame");
    }
    public void Minigame2()
    {
        SceneManager.LoadScene("FloppyFish");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Fish1");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Fish2");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Fish3");
    }
    public void Scene5()
    {
        SceneManager.LoadScene("Fish4");
    }
    public void Scene6()
    {
        SceneManager.LoadScene("Fish5");
    }
}
