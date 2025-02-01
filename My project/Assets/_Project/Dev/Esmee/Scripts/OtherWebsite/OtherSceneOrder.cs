using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherSceneOrder : MonoBehaviour
{
    public void Scene0()
    {
        SceneManager.LoadScene("FishPage");
    }
    public void Scene1()
    {
        SceneManager.LoadScene("FishGame");
    }
}
