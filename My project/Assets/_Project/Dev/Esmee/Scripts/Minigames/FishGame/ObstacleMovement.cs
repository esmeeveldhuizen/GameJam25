using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float speed = -4f;
    private float resetXPos = 20f;

    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < -25)
        {
            transform.position = new Vector3(resetXPos, transform.position.y, 0f);
        }
    }
}
