using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsertCode : MonoBehaviour
{
    public TMP_InputField input;
    private string answer2 = "mrbubbles";
    private string answer1 = "mutation";

    [SerializeField] private AudioSource confirmaudio;

    public void CheckAnswer()
    {
        string inputText = input.text;

        if (inputText == answer1)
        {
            SceneManager.LoadScene("InfectedFish");
            confirmaudio.Play();
        }

        if (inputText == answer2)
        {
            SceneManager.LoadScene("StartPage");
            confirmaudio.Play();
        }
    }
}

