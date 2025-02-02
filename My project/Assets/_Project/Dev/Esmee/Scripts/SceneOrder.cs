using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOrder : MonoBehaviour
{
    [SerializeField] private AudioSource clickAudio;
    //I'm sorry for this painfull to watch script, I am TIRED

    public void Scene0()
    {
        clickAudio.Play();
        SceneManager.LoadScene("AboutUs-ggis");
    }
    public void Scene1()
    {
        clickAudio.Play();
        SceneManager.LoadScene("GeneralQuestions");
    }
    public void Scene2()
    {
        clickAudio.Play();
        SceneManager.LoadScene("AquaHistory");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Blogs");
        clickAudio.Play();
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Photos-1");
        clickAudio.Play();
    }
    public void Scene5()
    {
        SceneManager.LoadScene("Photos-2");
        clickAudio.Play();
    }
    public void Scene6()
    {
        SceneManager.LoadScene("Comments");
        clickAudio.Play();
    }
    public void Scene7()
    {
        SceneManager.LoadScene("Locked");
        clickAudio.Play();
    }
    public void Scene8()
    {
        SceneManager.LoadScene("InfectedFish");
        clickAudio.Play();
    }
    public void Scene9()
    {
        SceneManager.LoadScene("StartPage");
        clickAudio.Play();
    }

}
