using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOrder : MonoBehaviour
{
    //I'm sorry for this painfull to watch script, I am TIRED

    public void Scene0()
    {
        SceneManager.LoadScene("AboutUs");
    }
    public void Scene1()
    {
        SceneManager.LoadScene("GeneralQuestions");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("AqueHistory");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Blogs");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Photos-1");
    }
    public void Scene5()
    {
        SceneManager.LoadScene("Photos-2");
    }


}
