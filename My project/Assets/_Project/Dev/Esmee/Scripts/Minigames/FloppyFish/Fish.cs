using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    private Rigidbody2D rb;
    private float flyForce = 200f;
    [SerializeField] private GameObject homeButton;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Fly();
    }

    private void Fly()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * flyForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        homeButton.SetActive(true);
    }
    public void GoBack()
    {
        SceneManager.LoadScene("FishPage");
    }
}
