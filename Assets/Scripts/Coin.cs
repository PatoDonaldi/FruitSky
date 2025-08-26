using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HUD.instance.AddPoints(10); // Atualiza HUD
            Destroy(gameObject);
        }
    }
}