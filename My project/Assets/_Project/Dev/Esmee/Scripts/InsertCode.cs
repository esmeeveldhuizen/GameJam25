using TMPro;
using UnityEngine;

public class InsertCode : MonoBehaviour
{
    public TMP_InputField input;
    private string answer = "8008";

    void Update()
    {
        string inputText = input.text;

        if (inputText == answer)
        {
            Debug.Log("YIPPAY");
            //loadscene ig
        }
    }
}

