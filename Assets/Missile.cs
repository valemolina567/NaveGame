using UnityEngine;

public class Missile : MonoBehaviour
{
    public int damage = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Ignorar colisión con quien disparó
        if (gameObject.CompareTag("PlayerBullet") && collision.CompareTag("Player"))
            return;

        if (gameObject.CompareTag("EnemyBullet") && collision.CompareTag("Enemies"))
            return;

        Health target = collision.GetComponent<Health>();

        if (target != null)
        {
            target.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}