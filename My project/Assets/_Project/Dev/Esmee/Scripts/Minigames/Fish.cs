using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private int health = 3;
    private Rigidbody2D rb;
    public float flyForce = 200f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckHealth();
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

    private void OnCollisionEnter(Collision collision)
    {
        health--;
    }

    private void GameOver()
    {

    }

    private void CheckHealth()
    {
        if (health >= 0)
        {
            GameOver();
        }
    }
}
