using UnityEngine;

public class SceneManagerTest : MonoBehaviour
{
    public string Scene;

    public void LoadScene()
    {
        if (Scene != null)
        {
            Debug.Log(Scene);
            UnityEngine.SceneManagement.SceneManager.LoadScene(Scene);
        }
        else if (Scene == null)
            Debug.Log("empty");
    }
}