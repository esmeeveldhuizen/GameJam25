using UnityEngine;

public class FishJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 600f;
    private bool isGrounded = true;
    [SerializeField] private GameObject fishGame;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            fishGame.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
