using System.Collections;
using UnityEngine;

public class SceneManagerTest : MonoBehaviour
{
    public string Scene;
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = FindFirstObjectByType<AudioSource>();
    }

    public void LoadScene()
    {
        if (Scene != null)
        {
            audioSource.Play();
            StartCoroutine(Wait());
        }
        else if (Scene == null)
            Debug.Log("empty");
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene);
    }
}