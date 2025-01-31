using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void NextPage()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
