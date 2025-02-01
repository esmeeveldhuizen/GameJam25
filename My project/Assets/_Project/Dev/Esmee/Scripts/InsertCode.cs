using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsertCode : MonoBehaviour
{
    public TMP_InputField input;
    private string answer = "mrbubbles";
    [SerializeField] private AudioSource confirmaudio;

    public void CheckAnswer()
    {
        string inputText = input.text;

        if (inputText == answer)
        {
            SceneManager.LoadScene("InfectedFish");
            confirmaudio.Play();
        }
    }
}

