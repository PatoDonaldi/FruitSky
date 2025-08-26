using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public float leftLimit = 4f;
    public float rightLimit = 7f;
    private int direction = 1;

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
            direction *= -1;
    }
}
