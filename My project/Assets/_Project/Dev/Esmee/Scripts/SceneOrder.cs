using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOrder : MonoBehaviour
{
    [SerializeField] private AudioSource clickAudio;
    //I'm sorry for this painfull to watch script, I am TIRED

    public void Scene0()
    {
        SceneManager.LoadScene("AboutUs-ggis");
        clickAudio.Play();
    }
    public void Scene1()
    {
        SceneManager.LoadScene("GeneralQuestions");
        clickAudio.Play();
    }
    public void Scene2()
    {
        SceneManager.LoadScene("AquaHistory");
        clickAudio.Play();
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

}
