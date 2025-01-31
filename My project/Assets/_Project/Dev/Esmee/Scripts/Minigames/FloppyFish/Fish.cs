using UnityEngine;

public class Fish : MonoBehaviour
{
    private Rigidbody2D rb;
    private float flyForce = 100f;
    [SerializeField] private GameObject floppyFish;
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
        floppyFish.SetActive(false);
    }

}
