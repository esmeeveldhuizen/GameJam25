using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float speed = -8f;
    private float resetXPos = 10f;

    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < 0)
        {
            transform.position = new Vector3(resetXPos, transform.position.y, 0f);
        }
    }
}
