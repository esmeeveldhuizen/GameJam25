using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float speed = -5f;
    private float resetXPos = 23f;
    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < -10)
        {
            transform.position = new Vector3(resetXPos, transform.position.y, 0f);
        }
    }
}
