using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private int health = 3;
    private float speed = 50;
    void Start()
    {

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
            transform.position = transform.position + new Vector3(0f, (speed * Time.deltaTime), 0f);
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
